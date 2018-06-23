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
        private LoginVM Login = new LoginVM();
        public MainPage() {
            Content = ControlFactory.PageTemplate(new PageContentVM() { Content = LoginBox(), TitleText= "Login" });
        }
        
        private StackLayout LoginBox()
        {
            var usernameEntry = new Entry { MaxLength = 25, Placeholder = "User Name" };
            usernameEntry.TextChanged += (o, e) =>
            {
                Login.UserName = ((Entry)o).Text;
            };
            var passwordEnty = new Entry { MaxLength = 25, Placeholder = "Password", IsPassword = true };
            passwordEnty.TextChanged += (o, e) =>
            {
                Login.PassWord = ((Entry)o).Text;
            };
            var loginFrame = new Frame()
            {
                BorderColor = Color.Purple,
                //Frames need a control object (not a collection)
                Content = new StackLayout() {
                    Children = {
                        usernameEntry,
                        passwordEnty
                    }
                }

            };
            return new StackLayout { HorizontalOptions = LayoutOptions.CenterAndExpand, Children = { loginFrame } };
        }
        private void DoLogin(object sender, EventArgs e)
        {
            //ToDo: Implement Login service
        }
    }

}
