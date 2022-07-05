using PalletizingReworked.Manager;
using PalletizingReworked.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalletizingReworked
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        UserManager _userManager = new UserManager();

        private string DescribeURL = "describe.json";
        private string Base = "https://appnostic.dbflex.net/secure/api/v2/";

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void setControls(bool yn)
        {
            btnLogin.Enabled = yn;
            btnCancel.Enabled = yn;
            txtUsername.Enabled = yn;
            txtPassword.Enabled = yn;
            txtDBID.Enabled = yn;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                setControls(false);
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtDBID.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setControls(true);
                }
                else
                {
                    await logIn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                setControls(true);
            }
        }

        public async Task logIn()
        {
            try
            {
                string username, password, dbid;
                username = txtUsername.Text;
                password = txtPassword.Text;
                dbid = txtDBID.Text;
                setControls(false);

                using (var client = new HttpClient())
                {
                    string URL = $"{Base}/{dbid}/";
                    client.BaseAddress = new Uri(URL);
                    var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(DescribeURL);
                    string resp = await response.Content.ReadAsStringAsync();

                    if ((resp.Contains("\"name\":")) || (resp.Contains("\"id\":")))
                    {
                        User user = new User();
                        user.Username = username;
                        user.Password = password;
                        user.DBID = dbid;
                        user.auth = 1;
                        if (_userManager.Add(user))
                        {
                            Application.Restart();
                        };
                    }
                    else
                    {
                        if (resp.Contains("Database does not exist"))
                        {
                            MessageBox.Show("Incorrect Database number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            setControls(true);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            setControls(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                setControls(true);
            }
        }

        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems =
            {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, a, 0},
                new float[] {0, 0, 0, 0, 1}
            };

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Bitmap original = (Bitmap)pbHome.Image.Clone();
            pbHome.Image = SetAlpha((Bitmap)original, 80);
            
        }
    }
}
