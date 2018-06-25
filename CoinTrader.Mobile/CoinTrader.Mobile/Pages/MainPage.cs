using CoinTrader.Mobile.Common;
using CoinTrader.Mobile.Models;
using CoinTrader.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Pages
{
    public class MainPage: ContentPage
    {
        private LoginVM Login = new LoginVM();
        public MainPage() {
            BackgroundImage = "mainbackground.jpg";
            Content = ControlFactory.PageTemplate(new PageContentVM() { Content = LoginBox(), TitleText= "Login" });
        }
        
        private AbsoluteLayout LoginBox()
        {
            var usernameEntry = new Entry {Placeholder = "API Key", HorizontalOptions = LayoutOptions.CenterAndExpand, WidthRequest=120 };
            usernameEntry.TextChanged += (o, e) =>
            {
                Login.UserName = ((Entry)o).Text;
            };
            var passwordEnty = new Entry { Placeholder = "Secret", IsPassword = true, HorizontalOptions=  LayoutOptions.CenterAndExpand, WidthRequest = 120 };
            passwordEnty.TextChanged += (o, e) =>
            {
                Login.PassWord = ((Entry)o).Text;
            };
            var loginButton = new Button { Text = "Start Trading!", HorizontalOptions = LayoutOptions.FillAndExpand, WidthRequest = 120 };
            loginButton.Clicked += DoLogin;


            var myImage = new Image { Source = FileImageSource.FromFile("selectionbox.png"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Aspect = Aspect.AspectFill };

            
            var loginbox = new AbsoluteLayout { Children = { myImage, new StackLayout { Children = { usernameEntry, passwordEnty, loginButton } } } };
            AbsoluteLayout.SetLayoutBounds(myImage, new Rectangle(0, 0, 120, 160));
            AbsoluteLayout.SetLayoutBounds(loginbox, new Rectangle((Shared.ScreenSize.Width/2)-60, 100, 120, 160));

            
            return loginbox;
        }
        private void DoLogin(object sender, EventArgs e)
        {
            //ToDo: Implement Login service
            //Eventually we want to have them relog in so someone cant mess with someone elses trading account - but as this is a POC, it's not worth the extra work.

            Common.Application.UserSettings = new Settings() { ApiKey = Login.UserName, ApiSecret = Login.PassWord };
            Common.Application.SaveSettings();
            App.ChangePage(page: new CurrenciesPage());

        }
    }

}
