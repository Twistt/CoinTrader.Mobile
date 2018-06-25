using CoinTrader.Mobile.Common;
using CoinTrader.Mobile.Models;
using CoinTrader.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Pages
{
    public class CurrenciesPage : ContentPage
    {
        public CurrenciesPage()
        {
            Content = ControlFactory.PageTemplate(new PageContentVM() { Content = GetCurrencyList(), TitleText = "Currencies" });
            BackgroundImage = "mainbackground.jpg";
        }
        public StackLayout GetCurrencyList()
        {
            BittrexExchange.GetBalances();
            if (BittrexExchange.APIKeyisInvalid) App.ChangePage(new MainPage());

            var tsection = new TableSection();
            foreach (var coin in Coin.AllCoins.Where(c=>c.Balance > 0))
            {
                tsection.Add(new ImageCell
                {
                    // Some differences with loading images in initial release.
                    ImageSource = ImageSource.FromFile(coin.Currency + ".png"),
                    Text = string.Format("{0} ({1})", coin.Currency, coin.Balance),
                    Detail = coin.MarketName
                });
            }
            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    tsection
                }
            };
                
            var layout = new StackLayout() { Children = { tableView }, Margin = new Thickness(0, 40, 0, 0), VerticalOptions = LayoutOptions.FillAndExpand, HeightRequest= Shared.ScreenSize.Height };
            //AbsoluteLayout.SetLayoutBounds(layout, new Rectangle(0, 20, 1, 1));
            return layout;
        }
    }
}
