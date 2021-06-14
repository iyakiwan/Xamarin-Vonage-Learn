using System;
using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using Xamarin.Forms.Xaml;

namespace VonageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart()
        {
            CrossVonage.Current.ApiKey = "47252544";
            CrossVonage.Current.UserToken = "T1==cGFydG5lcl9pZD00NzI1MjU0NCZzaWc9YjdjNjdjOTVhMmFkMDY5ODA5Yjc0NmNmNWExZTE1NjQ5YzQyNmQ5ZTpzZXNzaW9uX2lkPTJfTVg0ME56STFNalUwTkg1LU1UWXlNek15TURZeU5UQTNNWDVLTkVFeU1EaHVSSFZXT1ZOUllpdEpNWGRyUkV4bE4yUi1mZyZjcmVhdGVfdGltZT0xNjIzNjY0MDY5Jm5vbmNlPTAuMzY1NDM2OTI0NTUxMDk2MiZyb2xlPXB1Ymxpc2hlciZleHBpcmVfdGltZT0xNjIzNjY3NjY5JmluaXRpYWxfbGF5b3V0X2NsYXNzX2xpc3Q9";
            CrossVonage.Current.SessionId = "2_MX40NzI1MjU0NH5-MTYyMzMyMDYyNTA3MX5KNEEyMDhuRHVWOVNRYitJMXdrRExlN2R-fg";
            CrossVonage.Current.Error += (m) => MainPage.DisplayAlert("ERROR", m, "OK");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
