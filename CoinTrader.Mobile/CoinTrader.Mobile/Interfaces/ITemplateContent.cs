using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Interfaces
{
    public interface ITemplateContent
    {
        string TitleText { get; set; }
        Layout Content { get; set; }

    }
}
