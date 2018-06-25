using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoinTrader.Mobile.Models
{
    public class Settings
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public ObservableCollection<Coin> WatchList { get; set; }
    }
}
