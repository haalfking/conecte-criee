using conecte_crie.Models;

namespace conecte_crie.Views;

public partial class CadastroPage : ContentPage
{
    public CadastroPage()
    {
        InitializeComponent();
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        try
        {
            Usuario u = new Usuario
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Tipo = "Cliente"
            };

            App.Database.Salvar(u);

            await DisplayAlert("Sucesso", "Usuário cadastrado!", "OK");

            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}