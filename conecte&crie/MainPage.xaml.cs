using conecte_crie.Models;

namespace conecte_crie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            App.Database.Salvar(new Usuario
            {
                Nome = "Teste",
                Email = "teste@email.com",
                Senha = "123"
            });

            var lista = App.Database.Listar();

            foreach (var user in lista)
            {
                Console.WriteLine(user.Nome);
            }
        }
    }

}
