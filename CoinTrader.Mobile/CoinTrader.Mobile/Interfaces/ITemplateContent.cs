using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Interfaces
{
    public interface ITemplateContent
    {
        string TitleText { get; set; }
        View Content { get; set; }
        bool UseFooterCoinIcon { get; set; }
        string CoinIcon { get; set; }
    }
}
