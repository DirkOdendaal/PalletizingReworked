using PalletizingReworked.Manager;
using PalletizingReworked.Models;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace PalletizingReworked.Classes
{
    public class LabelPrintController
    {
        ScaleSettingsManager _scaleManager = new ScaleSettingsManager();

        public void printLabel(string printLab)
        {
            try
            {
                bool qr = false;
                bool barcode = false;

                switch (printLab)
                {
                    case "QR":
                        qr = true;
                        break;
                    case "BAR":
                        barcode = true;
                        break;
                    case "BARQR":
                        qr = true;
                        barcode = true;
                        break;
                    default:
                        qr = false;
                        barcode = false;
                        break;
                }
                ScaleSettings settings = new ScaleSettings();

                settings = _scaleManager.GetSettings();
                if (qr == true && barcode == false)
                {
                    PrintDocument pd = new PrintDocument();
                    PrintController pc = new StandardPrintController();
                    pd.PrintController = pc;
                    pd.PrintPage += (s, args) =>
                    {
                        Image i = Image.FromFile(@"QR.jpg");
                        Point p = new Point(0, 0);
                        args.Graphics.DrawImage(i, 125, 0, Convert.ToInt32(settings.qrSize), Convert.ToInt32(settings.qrSize));
                    };
                    for (int k = 0; k < settings.printCount; k++)
                        pd.Print();
                }
                if (barcode == true && qr == false)
                {
                    PrintDocument pd = new PrintDocument();
                    PrintController pc = new StandardPrintController();
                    pd.PrintController = pc;
                    pd.PrintPage += (s, args) =>
                    {
                        Image i = Image.FromFile(@"barcode.jpg");
                        Point p = new Point(0, 0);
                        args.Graphics.DrawImage(i, 10, 10, Convert.ToInt32(settings.barWidth), Convert.ToInt32(settings.barHeight));
                    };
                    for (int k = 0; k < settings.printCount; k++)
                        pd.Print();
                }
                if (barcode == true && qr == true)
                {
                    PrintDocument pd = new PrintDocument();
                    PrintController pc = new StandardPrintController();
                    pd.PrintController = pc;
                    pd.PrintPage += (s, args) =>
                    {
                        Image i = Image.FromFile(@"barcode.jpg");
                        Image b = Image.FromFile(@"QR.jpg");

                        Point p = new Point(0, 0);
                        args.Graphics.DrawImage(b, 125, 0, Convert.ToInt32(settings.qrSize), Convert.ToInt32(settings.qrSize));
                        args.Graphics.DrawImage(i, 10, Convert.ToInt32(settings.qrSize), Convert.ToInt32(settings.barWidth), Convert.ToInt32(settings.barHeight));
                    };
                    for (int k = 0; k < settings.printCount; k++)
                        pd.Print();
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
            }
        }

        public void printMass(string mass, float size)
        {
            ScaleSettings settings = new ScaleSettings();
            settings = _scaleManager.GetSettings();
            for (int k = 0; k < settings.printCount; k++)
            {
                Font font = new Font(FontFamily.GenericSansSerif, size, FontStyle.Bold);
                DrawText(mass, font, Color.Black, Color.Transparent);
            }
        }

        private void DrawText(String text, Font font, Color textColor, Color backColor)
        {
            try
            {
                //first, create a dummy bitmap just to get a graphics object
                Image img = new Bitmap(1, 1);
                Graphics drawing = Graphics.FromImage(img);

                //measure the string to see how big the image needs to be
                SizeF textSize = drawing.MeasureString(text, font);

                //free up the dummy image and old graphics object
                img.Dispose();
                drawing.Dispose();

                //create a new image of the right size
                img = new Bitmap((int)textSize.Width, (int)textSize.Height);

                drawing = Graphics.FromImage(img);

                //paint the background
                drawing.Clear(backColor);

                //create a brush for the text
                Brush textBrush = new SolidBrush(textColor);

                drawing.DrawString(text, font, textBrush, 0, 0);

                drawing.Save();

                textBrush.Dispose();
                drawing.Dispose();

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, args) =>
                {
                    args.Graphics.DrawImage(img, 0, 0, img.Width, img.Height);
                };
                pd.Print();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("-----");
                }
            }
        }
    }
}
