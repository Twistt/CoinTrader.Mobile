using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Pages
{
    public class MainPage: ContentPage
    {
        public MainPage() {
            Content = new StackLayout {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Frame() {
                        BorderColor = Color.Purple,
                        //This needs a control object (not a collection)
                         Content = 
                            new Label(){Text = "We are in a frame?", HorizontalTextAlignment = TextAlignment.Center}
                        
                } }
            };
        }
    }
}
