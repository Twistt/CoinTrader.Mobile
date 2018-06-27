using CoinTrader.Mobile.Common;
using CoinTrader.Mobile.Models;
using CoinTrader.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace CoinTrader.Mobile.Pages
{
    public class CoinPage: ContentPage
    {
        private WebView controlCollection = null;
        private Coin coin = null;
        public CoinPage(Coin Coin)
        {
            coin = Coin;
            BackgroundImage = "mainbackground.jpg";
            Content = ControlFactory.PageTemplate(new PageContentVM() { Content = ShowCoinInfo(), TitleText = "Login", UseFooterCoinIcon = true, CoinIcon = coin.Currency + ".png" });
        }
        public WebView ShowCoinInfo()
        {
            UpdateCoinTicker();
            Label label = new Label() { BindingContext = coin};
            label.SetBinding(Label.TextProperty, "LastPurchasePrice");
            controlCollection = new WebView() { Source= "https://bittrex.com/Market/Index?MarketName="+ coin.MarketName, Margin = new Thickness(0, 40, 0, 0), VerticalOptions = LayoutOptions.FillAndExpand, HeightRequest = Shared.ScreenSize.Height };
            return controlCollection;
            
        }
        public void UpdateCoinTicker()
        {
            Task task = new Task(()=> {
                BittrexExchange.UpdateTickers(coin);
            });
        }



    }
}
