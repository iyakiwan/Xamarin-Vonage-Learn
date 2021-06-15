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
            CrossVonage.Current.UserToken = "T1==cGFydG5lcl9pZD00NzI1MjU0NCZzaWc9YTU0ZWVlNTQzMWU5MmYzNmRlNGQ3MjRlYjk2OWFmNzZjZmNiMjdiNTpzZXNzaW9uX2lkPTFfTVg0ME56STFNalUwTkg1LU1UWXlNemMwTlRVME5qZzBPSDVFTm5wdmVuWTNOR0YyUVVNd1JFczVhMGhwZFM5elEzSi1mZyZjcmVhdGVfdGltZT0xNjIzNzQ1NTcyJm5vbmNlPTAuMTAyMzg2NTkzODAzNTU2ODYmcm9sZT1wdWJsaXNoZXImZXhwaXJlX3RpbWU9MTYyMzc2NzE2OSZpbml0aWFsX2xheW91dF9jbGFzc19saXN0PQ==";
            CrossVonage.Current.SessionId = "1_MX40NzI1MjU0NH5-MTYyMzc0NTU0Njg0OH5ENnpvenY3NGF2QUMwREs5a0hpdS9zQ3J-fg";
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
