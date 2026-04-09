using conecte_crie.Models;

namespace conecte_crie.Views;

public partial class ProdutosPage : ContentPage
{
    public ProdutosPage()
    {
        InitializeComponent();
        CarregarProdutos();
    }

    private void CarregarProdutos()
    {
        var produtos = App.ProdutoDB.Listar();
        collectionProdutos.ItemsSource = produtos;
    }
}