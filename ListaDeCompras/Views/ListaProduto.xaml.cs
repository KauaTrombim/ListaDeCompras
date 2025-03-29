using ListaDeCompras.Models;
using System.Collections.ObjectModel;   

namespace ListaDeCompras.Views;

public partial class ListaProduto : ContentPage
{
	ObservableCollection<Produto> lista = new ObservableCollection<Produto>();
    public ListaProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Views.NovoProduto());
        }
        catch (Exception ex)
		{
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}