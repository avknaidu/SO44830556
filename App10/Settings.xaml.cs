using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace App10
{
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["BackgroundBrush"] = (cb.SelectedValue as ComboBoxItem).Content;
            App.UpdateBGColors((cb.SelectedValue as ComboBoxItem).Content.ToString());
        }
    }
}
