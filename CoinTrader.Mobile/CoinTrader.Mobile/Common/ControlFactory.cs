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

            var layout = new AbsoluteLayout
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
            if (pageContent.UseFooterCoinIcon)
            {
                //we can pass the layout around and add to it - but I think this method is cleaner.
                layout.Children.Add(CoinIconContainer());
                layout.Children.Add(PlaceCoinIcon(pageContent));
                
            }
            return layout;

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
            var footerBGImage = new Image()
            {
                Source = FileImageSource.FromFile("footerbg.png")
            };

            var layout = new AbsoluteLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
             };
            footerBGImage.HorizontalOptions = LayoutOptions.CenterAndExpand;

            layout.Children.Add(footerBGImage);

            AbsoluteLayout.SetLayoutBounds(layout, new Rectangle(0, Shared.ScreenSize.Height-60, Shared.ScreenSize.Width, 160));
            
            return layout;
        }

        public static View CoinIconContainer() {
            var iconBGImage = new Image()
            {
                Source = FileImageSource.FromFile("coincallout.png")
            };
            //the icon width should be 1/3 of the width of the footer.
            //so if we want it centered we have to subtract half of teh width since the icon starts with the first pixel on teh center line.
            var halficonwidth = ((Shared.ScreenSize.Width / 3) / 2);
            AbsoluteLayout.SetLayoutBounds(iconBGImage, new Rectangle((Shared.ScreenSize.Width / 2) - halficonwidth, Shared.ScreenSize.Height - 110, Shared.ScreenSize.Width / 3, 100));
            return iconBGImage;
        }
        public static View PlaceCoinIcon(ITemplateContent pageContent)
        {
            var iconBGImage = new Image()
            {
                Source = FileImageSource.FromFile(pageContent.CoinIcon)
            };
            //the icon width should be 1/3 of the width of the footer.
            //so if we want it centered we have to subtract half of teh width since the icon starts with the first pixel on teh center line.
            var halficonwidth = ((Shared.ScreenSize.Width / 3.5) / 2);
            AbsoluteLayout.SetLayoutBounds(iconBGImage, new Rectangle((Shared.ScreenSize.Width / 2) - halficonwidth, Shared.ScreenSize.Height - 110, Shared.ScreenSize.Width / 3.5, 100));
            return iconBGImage;
        }
    }
}
