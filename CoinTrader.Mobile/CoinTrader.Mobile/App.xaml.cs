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

			MainPage = new MainPage();
		}
        public static void ChangePage(ContentPage page)
        {
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
