using CoinTrader.Mobile.Common;
using CoinTrader.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Pages
{
    public class Currencies : ContentPage
    {
        public Currencies()
        {
            Content = ControlFactory.PageTemplate(new PageContentVM() { Content = GetCurrencyList(), TitleText = "Currencies" });
        }
        public StackLayout GetCurrencyList()
        {
            return new StackLayout();
        }
    }
}
