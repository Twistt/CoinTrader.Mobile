using CoinTrader.Mobile.Common;
using CoinTrader.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Pages
{
    public class MainPage: ContentPage
    {
        public MainPage() {
            Content = ControlFactory.PageTemplate(new PageContentVM() { Content = LoginBox(), TitleText= "Login" });
        }
        
        private StackLayout LoginBox()
        {
            var loginBoxes = new AbsoluteLayout() {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,


            };
            var loginFrame = new Frame()
            {
                BorderColor = Color.Purple,
                //This needs a control object (not a collection)
                Content = new Label() { Text = "We are in a frame?", HorizontalTextAlignment = TextAlignment.Center }

            };
            return new StackLayout { HorizontalOptions = LayoutOptions.CenterAndExpand, Children = { loginFrame } };
        }
    }
}
