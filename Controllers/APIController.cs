using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Palletizing.Manager;
using PalletizingReworked.Manager;
using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Classes
{
    public class APIController
    {
        UserManager _userManager = new UserManager();
        BlocksManager _blockManager = new BlocksManager();
        BrandManager _brandManager = new BrandManager();
        PackManager _packManager = new PackManager();
        GradeManager _gradeManager = new GradeManager();
        Count_SizeManager _countManager = new Count_SizeManager();
        PalletsManager _palletManager = new PalletsManager();

        string Base = "https://appnostic.dbflex.net/secure/api/v2/";
        public int toSkip = 0;

        public async Task annualCensus()
        {
            try
            {
                User user = new User();
                user = _userManager.GetUser();

                string blocksUrl = $"Annual%20Census/Relationship%20View/select.json?&skip={toSkip}";

                using (var client = new HttpClient())
                {
                    string URL = $"{Base}{user.DBID}/";
                    client.BaseAddress = new Uri(URL);
                    var byteArray = Encoding.ASCII.GetBytes($"{user.Username}:{user.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(blocksUrl);
                    var blockList = await response.Content.ReadAsAsync<List<Blocks>>();
                    if (!_blockManager.AddRange(blockList))
                    {
                        return;
                    }

                    if (blockList.Count >= 500 && !response.ToString().Contains("Content-Length: 2"))
                    {
                        toSkip += 500;
                        await annualCensus();
                    }
                }
                toSkip = 0;
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

        public async Task pullBrand()
        {
            try
            {
                User user = new User();
                user = _userManager.GetUser();
                string brandUrl = $"Brand/select.json?skip={toSkip}";

                using (var client = new HttpClient())
                {
                    string URL = $"{Base}{user.DBID}/";
                    client.BaseAddress = new Uri(URL);
                    var byteArray = Encoding.ASCII.GetBytes($"{user.Username}:{user.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(brandUrl);
                    var brandList = await (response.Content.ReadAsAsync<List<Brand>>());

                    if (!_brandManager.AddRange(brandList))
                    {
                        return;
                    }

                    if (brandList.Count >= 500 && !response.ToString().Contains("Content-Length: 2"))
                    {
                        toSkip += 500;
                        await pullBrand();
                    }
                }
                toSkip = 0;
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

        public async Task pullPack()
        {
            try
            {
                User user = new User();
                user = _userManager.GetUser();
                string brandUrl = $"Pack%20Type/Active%20Pack%20Types/select.json?skip={toSkip}";

                using (var client = new HttpClient())
                {
                    string URL = $"{Base}{user.DBID}/";
                    client.BaseAddress = new Uri(URL);
                    var byteArray = Encoding.ASCII.GetBytes($"{user.Username}:{user.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(brandUrl);
                    var packList = await (response.Content.ReadAsAsync<List<Pack>>());

                    if (!_packManager.AddRange(packList))
                    {
                        return;
                    }

                    if (packList.Count >= 500 && !response.ToString().Contains("Content-Length: 2"))
                    {
                        toSkip += 500;
                        await pullPack();
                    }
                }
                toSkip = 0;
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

        public async Task pullGrade()
        {
            try
            {
                User user = new User();
                user = _userManager.GetUser();
                string gradeURL = $"Grade/select.json?skip={toSkip}";

                using (var client = new HttpClient())
                {
                    string URL = $"{Base}{user.DBID}/";
                    client.BaseAddress = new Uri(URL);
                    var byteArray = Encoding.ASCII.GetBytes($"{user.Username}:{user.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(gradeURL);
                    var gradeList = await (response.Content.ReadAsAsync<List<Grade>>());

                    if (!_gradeManager.AddRange(gradeList))
                    {
                        return;
                    }

                    if (gradeList.Count >= 500 && !response.ToString().Contains("Content-Length: 2"))
                    {
                        toSkip += 500;
                        await pullGrade();
                    }
                }
                toSkip = 0;
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

        public async Task pullCount()
        {
            try
            {
                User user = new User();
                user = _userManager.GetUser();
                string countUrl = $"Count%252FSize/select.json?skip={toSkip}";

                using (var client = new HttpClient())
                {
                    string URL = $"{Base}{user.DBID}/";
                    client.BaseAddress = new Uri(URL);
                    var byteArray = Encoding.ASCII.GetBytes($"{user.Username}:{user.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(countUrl);
                    var countList = await (response.Content.ReadAsAsync<List<Count>>());

                    if (!_countManager.AddRange(countList))
                    {
                        return;
                    }

                    if (countList.Count >= 500 && !response.ToString().Contains("Content-Length: 2"))
                    {
                        toSkip += 500;
                        await pullCount();
                    }
                }
                toSkip = 0;
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

        public async Task<string> addPallet(PalletRecord record)
        {
            try
            {
                string json = JsonConvert.SerializeObject(record);

                User user = new User();
                user = _userManager.GetUser();
                string addPalletUrl = "Palletizing/create.json";
                using (var client = new HttpClient())
                {
                    string URL = $"{Base}{user.DBID}/";
                    client.BaseAddress = new Uri(URL);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var byteArray = Encoding.ASCII.GetBytes($"{user.Username}:{user.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    client.DefaultRequestHeaders.Accept.Clear();

                    HttpResponseMessage response = await client.PostAsync(addPalletUrl, data);
                    var result = await response.Content.ReadAsStringAsync();

                    try
                    {
                        JArray resp = (JArray)JsonConvert.DeserializeObject(result);
                        if (resp != null)
                        {
                            foreach (JObject obj in resp)
                            {
                                string key = (string)obj.GetValue("key");
                                string palID = (string)obj.GetValue("Pallet Number");
                                switch (Convert.ToInt32(obj.GetValue("status")))
                                {
                                    //modified
                                    case 304:
                                        //Console.WriteLine("Record Updated");
                                        _palletManager.UpdatePallet(key);
                                        return key;
                                    //created
                                    case 201:
                                        //Console.WriteLine("Record Created");
                                        _palletManager.UpdatePallet(key);
                                        return key;
                                    //errors with appropriate message
                                    case 400:
                                        JToken msg = obj.SelectToken("errors[0].message");
                                        JToken src = obj.SelectToken("errors[0].source");

                                        if (msg.ToString() == "Column does not exist")
                                        {
                                            //Hopfulle create column api would be good
                                            using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                                            {
                                                sw.WriteLine(DateTime.Now.ToString());
                                                sw.WriteLine($"Missing column. Contact a system administrator to create \"{src}\" column");
                                                sw.WriteLine("-----");
                                            }
                                            return null;
                                        }
                                        if (msg.ToString() == $"Cannot insert duplicate value \"{key}\" into column \"Id\"")
                                        {
                                            _palletManager.UpdatePallet(key);
                                            return key;
                                        }
                                        if (msg.ToString().Contains("into column \"PalletID\""))
                                        {
                                            _palletManager.UpdatePallet(key);
                                            return key;
                                        }
                                        else
                                        {
                                            //Console.WriteLine(msg + ", Source: " + src);
                                            using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                                            {
                                                sw.WriteLine(DateTime.Now.ToString());
                                                sw.WriteLine(msg + ", Source: " + src);
                                                sw.WriteLine("-----");
                                            }
                                        }
                                        return null;
                                    case 401:
                                        JToken msg1 = obj.SelectToken("errors[0].message");
                                        JToken src1 = obj.SelectToken("errors[0].source");
                                        //Console.WriteLine(msg1 + ", Source: " + src1);
                                        using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                                        {
                                            sw.WriteLine(DateTime.Now.ToString());
                                            sw.WriteLine(msg1 + ", Source: " + src1);
                                            sw.WriteLine("-----");
                                        }
                                        return null;
                                    case 403:
                                        JToken msg2 = obj.SelectToken("errors[0].message");
                                        JToken src2 = obj.SelectToken("errors[0].source");
                                        //Console.WriteLine(msg2 + ", Source: " + src2);
                                        using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                                        {
                                            sw.WriteLine(DateTime.Now.ToString());
                                            sw.WriteLine(msg2 + ", Source: " + src2);
                                            sw.WriteLine("-----");
                                        }
                                        return null;
                                    case 500:
                                        JToken msg3 = obj.SelectToken("errors[0].message");
                                        JToken src3 = obj.SelectToken("errors[0].source");
                                        //Console.WriteLine(msg3 + ", Source: " + src3);
                                        using (StreamWriter sw = File.AppendText(@"errorlog.txt"))
                                        {
                                            sw.WriteLine(DateTime.Now.ToString());
                                            sw.WriteLine(msg3 + ", Source: " + src3);
                                            sw.WriteLine("-----");
                                        }
                                        return null;
                                }
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        return null;
                    }
                    catch (InvalidCastException)
                    {
                        //Handle Errors if not parsable
                        JObject resp = (JObject)JsonConvert.DeserializeObject(result);
                        if (resp.ContainsKey("error"))
                        {
                            //No Records Or to Many records in packet
                            if (resp.GetValue("message").ToString() == "Expected number of records between 1 and 500")
                            {
                                Console.WriteLine("Expected number of records between 1 and 500");
                            }
                        }
                        return null;
                    }
                    return null;
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
                return null;
            }
        }
    }
}
