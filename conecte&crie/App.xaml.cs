using conecte_crie.Database;
using conecte_crie.Models;
using System.IO;
using System.Linq;

namespace conecte_crie
{
    public partial class App : Application
    {
        public static UsuarioDatabase Database;
        public static ProdutoDatabase ProdutoDB;
        public static Usuario UsuarioLogado;

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db");
            Database = new UsuarioDatabase(dbPath);

            string dbProdutoPath = Path.Combine(FileSystem.AppDataDirectory, "produtos.db");
            ProdutoDB = new ProdutoDatabase(dbProdutoPath);

            // 🔥 CRIA ADMIN AUTOMÁTICO
            var usuarios = Database.Listar();

            if (!usuarios.Any(u => u.Email == "admin@admin.com"))
            {
                Database.Salvar(new Usuario
                {
                    Nome = "Administrador",
                    Email = "admin@admin.com",
                    Senha = "123",
                    Tipo = "Admin"
                });
            }

            MainPage = new NavigationPage(new Views.LoginPage());
        }
    }
}
