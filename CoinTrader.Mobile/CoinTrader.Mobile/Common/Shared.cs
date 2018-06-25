using CoinTrader.Mobile.Models;
using Plugin.XamJam.Screen.Abstractions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CoinTrader.Mobile.Common
{
    public static class Shared
    {
        public static ScreenSize ScreenSize = Plugin.XamJam.Screen.CrossScreen.Current.Size;


        public static async void GetData(string url = null, Exchange exchange = null)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // Download the data from the remote server
                    Uri uri = null;
                    if (!string.IsNullOrEmpty(url)) uri = new Uri(url);
                    if (exchange != null ) uri = new Uri(string.Format("http://", exchange.ApiUrl));

                    //Download Images
                    byte[] data = await webClient.DownloadDataTaskAsync(uri);

                    //Download text 
                    //string sdata = await webClient.DownloadStringAsync(uri);
                }
                catch
                {
                }
            }
        }

    }
}
