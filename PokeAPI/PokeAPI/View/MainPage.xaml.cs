using PokeAPI.ViewModel;
using Android.Gms.Common;
using Firebase.Messaging;
using Firebase.Iid;

namespace PokeAPI.View;

public partial class MainPage : ContentPage
{

	public MainPage( PokeMasterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	
}

