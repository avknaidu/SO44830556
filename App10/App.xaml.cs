using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace App10
{
    sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            if (localSettings.Values["BackgroundBrush"] != null)
            {
                UpdateBGColors(localSettings.Values["BackgroundBrush"].ToString());
            }

            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                Window.Current.Activate();
            }
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        public static void UpdateBGColors(string Color)
        {
            switch (Color)
            {
                case "Red":
                    Current.Resources["BackgroundSource"] = "ms-appx:///Assets/Red.png";
                    break;
                case "Green":
                    Current.Resources["BackgroundSource"] = "ms-appx:///Assets/Green.png";
                    break;
                case "Blue":
                    Current.Resources["BackgroundSource"] = "ms-appx:///Assets/Blue.png";
                    break;
                default:
                    Current.Resources["BackgroundSource"] = "ms-appx:///Assets/Green.png";
                    break;
            }
        }
    }
}
