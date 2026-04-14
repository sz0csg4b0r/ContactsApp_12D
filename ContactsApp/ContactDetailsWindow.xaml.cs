using ContactsApp.Model;
using System.Windows;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for ContactDetailsWindow.xaml
    /// </summary>
    public partial class ContactDetailsWindow : Window
    {
        Contact contact;
        public ContactDetailsWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            phoneTextBox.Text = contact.Phone;

        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = nameTextBox.Text;
            contact.Email = emailTextBox.Text;
            contact.Phone = phoneTextBox.Text;

            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.Update(contact);
            }
            Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.Delete(contact);
            }
            Close();
        }
    }
}
