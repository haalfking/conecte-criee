using conecte_crie.Database;
using System.IO;

namespace conecte_crie
{
    public partial class App : Application
    {
        public static UsuarioDatabase Database;
        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db");
            Database = new UsuarioDatabase(dbPath);


            MainPage = new NavigationPage(new Views.LoginPage());
        }
    }
}
