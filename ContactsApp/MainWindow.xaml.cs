using ContactsApp.Model;
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
        List<Contact> contacts;

        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            ReadDatabase();
        }

        private void ReadDatabase()
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasePath))
            {
                // Lekérdez a Contact SQLITE táblából
                connection.CreateTable<Contact>();
                contacts = connection.Table<Contact>().ToList();

                // WPF elem (listview) megkapja a contact list adatokat
                if (contacts != null)
                {
                    contactsList.ItemsSource = contacts;
                }
            }
        }

        private void newContactBtn_Click(object sender, RoutedEventArgs e)
        {
            NewContatctWindow newContatctWindow = new NewContatctWindow();
            newContatctWindow.ShowDialog();
            ReadDatabase();

        }

        private void filterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredList = contacts.Where(c => c.Name.ToLower().Contains(filterBox.Text.ToLower())).ToList();
            contactsList.ItemsSource = filteredList;

        }

        private void contactsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // kiválasztott objektum 
            Contact selectedContact = (Contact)contactsList.SelectedItem;

            if (selectedContact != null)
            {
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();
                ReadDatabase();
            }
        }
    }
}