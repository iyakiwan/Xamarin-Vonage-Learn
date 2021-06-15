using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Vonage;

namespace VonageApp
{
    public partial class MainPage : ContentPage
    {
        private bool _isRendererSet;
        private bool voice = true, video = true;

        public MainPage()
        {
            InitializeComponent();
            CrossVonage.Current.MessageReceived += OnMessageReceived;
        }

        private void OnEndCall(object sender, EventArgs e)
        {
            CrossVonage.Current.EndSession();
            CrossVonage.Current.MessageReceived -= OnMessageReceived;
            Navigation.PopAsync();
        }

        private void OnMessage(object sender, EventArgs e)
            => CrossVonage.Current.TrySendMessage($"Path.GetRandomFileName: {Path.GetRandomFileName()}");

        private void OnSwapCamera(object sender, EventArgs e)
            => CrossVonage.Current.CycleCamera();

        private void OnCamera(object sender, EventArgs e)
        {
            video = !video;
            if (video)
            {
                btnMuteCamera.Source = "videocam_on.png";
                CrossVonage.Current.IsVideoPublishingEnabled = true;

            }
            else
            {
                btnMuteCamera.Source = "videocam_off.png";
                CrossVonage.Current.IsVideoPublishingEnabled = false;
            }
        }

        private void OnVoice(object sender, EventArgs e)
        {
            voice = !voice;
            if (voice)
            {
                btnMute.Source = "mic_on.png";
                CrossVonage.Current.IsAudioPublishingEnabled = true;
            }
            else
            {
                btnMute.Source = "mic_off.png";
                CrossVonage.Current.IsAudioPublishingEnabled = false;
            }
        }

        void OnShareScreen(object sender, EventArgs e)
        {
            CrossVonage.Current.PublisherVideoType = CrossVonage.Current.PublisherVideoType == VonagePublisherVideoType.Camera
                ? VonagePublisherVideoType.Screen
                : VonagePublisherVideoType.Camera;
        }

        private void OnMessageReceived(string message)
            => DisplayAlert("Random message received", message, "OK");

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == "Renderer")
            {
                _isRendererSet = !_isRendererSet;
                if (!_isRendererSet)
                {
                    OnEndCall(this, EventArgs.Empty);
                }
            }
        }
    }
}
