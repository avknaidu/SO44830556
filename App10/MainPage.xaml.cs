using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace App10
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch(int.Parse(btn.Tag.ToString()))
            {
                case 0:
                    MyFrame.Navigate(typeof(Settings));
                    break;
                case 1:
                    MyFrame.Navigate(typeof(BlankPage1));
                    break;
                case 2:
                    MyFrame.Navigate(typeof(BlankPage2));
                    break;
                case 3:
                    MyFrame.Navigate(typeof(BlankPage3));
                    break;
            }
        }
    }
}
