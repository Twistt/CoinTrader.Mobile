using CoinTrader.Mobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoinTrader.Mobile.Common
{
    public static class Application
    {
        public static Settings UserSettings { get; set; }
        public static User ActiveUser { get; set; }
        public static void SaveSettings()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "CoinTraderSettings.json");

            File.WriteAllText(filename, JsonConvert.SerializeObject(UserSettings));
        }
        public static void LoadSettings()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "CoinTraderSettings.json");
            if (File.Exists(filename))
            {
                using (var streamReader = new StreamReader(filename))
                {
                    string content = streamReader.ReadToEnd();
                    UserSettings = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(content);
                }
            } else
            {
                UserSettings = new Settings();
            }
        }
    }
}
