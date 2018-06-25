using CoinTrader.Mobile.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace CoinTrader.Mobile
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();
            Common.Application.LoadSettings();
            //If there is saved api data then we dont need to have them input it again. Just go to the currencies page.
            if (!string.IsNullOrEmpty(Common.Application.UserSettings.ApiKey) && !string.IsNullOrEmpty(Common.Application.UserSettings.ApiSecret)) MainPage = new NavigationPage(new CurrenciesPage());
            else MainPage = new MainPage();
		}
        public static void ChangePage(ContentPage page)
        {
            NavigationPage.SetHasNavigationBar(page, false);
            Application.Current.MainPage = page;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
