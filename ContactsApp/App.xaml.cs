using System.Configuration;
using System.Data;
using System.Windows;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //sqlite db params
        static string databaseName = "Contacts.db";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);
    }

}
