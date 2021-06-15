using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Vonage;

namespace VonageApp
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Button
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Text = "CLICK TO VIDEO CALL",
                        Command = new Command(() => {
                            if(!CrossVonage.Current.TryStartSession())
                            {
                                return;
                            }
                            Navigation.PushAsync(new MainPage());
                        })
                    }
                }
            };
        }
    }
}
