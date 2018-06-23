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

            return new StackLayout()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    GenerateHeader(pageContent),
                    pageContent.Content
                    
                }

            };

        }
        public static Frame GenerateHeader(ITemplateContent pageContent) {
            
            return new Frame {
                BackgroundColor = Color.LightGray,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = 5,
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                        new Label {
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Start,
                            Text = "CoinTrader",
                            TextColor = Color.Purple
                        },
                        new Label {
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            Text = pageContent.TitleText,
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            HorizontalTextAlignment = TextAlignment.End,
                            TextColor = Color.MediumPurple
                        }
                    }
                }
            };
        }
    }
}
