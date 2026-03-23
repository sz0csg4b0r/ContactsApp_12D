using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newContactBtn_Click(object sender, RoutedEventArgs e)
        {
            NewContatctWindow newContatctWindow = new NewContatctWindow();
            newContatctWindow.ShowDialog();

        }

        private void filterBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void contactsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}