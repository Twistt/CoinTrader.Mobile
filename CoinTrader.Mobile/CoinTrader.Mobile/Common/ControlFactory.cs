using CoinTrader.Mobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CoinTrader.Mobile.Common
{
    public static class ControlFactory
    {
        public static Layout PageTemplate(ITemplateContent pageContent)
        {
            //https://github.com/jasonCodesAway/XamJam/tree/master/XamJam.Screen
            //var maxArea = size.Width * size.Height;
            //var isGuaranteedMax = size.IsMaximum;

            return new AbsoluteLayout
            {
                AnchorX=0,
                AnchorY=0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    GenerateHeader(pageContent),
                    pageContent.Content,
                    GenerateFooter()

                }

            };

        }
        public static AbsoluteLayout GenerateHeader(ITemplateContent pageContent)
        {
            var myImage = new Image()
            {
                Source = FileImageSource.FromFile("headerbg.png")
            };
            var layout = new AbsoluteLayout()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                AnchorX = 0,
                AnchorY = 0
            };
            //AbsoluteLayout.SetLayoutBounds(myImage, new Rectangle(0, 0, 1, 1));
            myImage.HorizontalOptions = LayoutOptions.CenterAndExpand;

            layout.Children.Add(myImage);
            AbsoluteLayout.SetLayoutBounds(layout, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(layout, AbsoluteLayoutFlags.All);
            return layout;
        }

        public static AbsoluteLayout GenerateFooter()
        {
            var myImage = new Image()
            {
                Source = FileImageSource.FromFile("footerbg.png")
            };
            var layout = new AbsoluteLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
             };
            myImage.HorizontalOptions = LayoutOptions.CenterAndExpand;

            layout.Children.Add(myImage);
            AbsoluteLayout.SetLayoutBounds(layout, new Rectangle(0, Shared.ScreenSize.Height-60, Shared.ScreenSize.Width, 160));
            return layout;
        }
    }
}
