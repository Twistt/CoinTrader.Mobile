
using CoinTrader.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinTrader.Mobile.ViewModels
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public User LoggedInUser { get; set; }
    }
}
