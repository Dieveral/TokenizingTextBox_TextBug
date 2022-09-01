using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TokenizingTextBox_TextBug
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tokenizingBox.Text = string.Empty;
        }
    }
}
