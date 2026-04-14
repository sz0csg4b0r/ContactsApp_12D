using ContactsApp.Model;
using System.Windows;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for NewContatctWindow.xaml
    /// </summary>
    public partial class NewContatctWindow : Window
    {
        public NewContatctWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text
            };

            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<Contact>();
                sQLiteConnection.Insert(contact);
            }
            Close();
        }
    }
}
