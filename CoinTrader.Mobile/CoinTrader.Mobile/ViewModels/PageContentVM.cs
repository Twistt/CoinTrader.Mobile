using CoinTrader.Mobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.ViewModels
{
    public class PageContentVM : ITemplateContent
    {
        public string TitleText { get; set; }
        public View Content { get; set; }
        public bool UseFooterCoinIcon { get; set; }
        public string CoinIcon { get;  set; }
    }
}
