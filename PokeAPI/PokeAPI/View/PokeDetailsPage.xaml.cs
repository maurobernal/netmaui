using PokeAPI.ViewModel;

namespace PokeAPI.View;

public partial class PokeDetailsPage : ContentPage
{
	
	public PokeDetailsPage(PokeDetailsViewModels viewmodel )
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}