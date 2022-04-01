using Microsoft.Maui.Controls;

namespace NetMAUI_Clase5_Bindings;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Lbl_Codigo.BindingContext = Sld_Posicion;
		Lbl_Codigo.SetBinding(Label.RotationProperty,"Value");
		//Lbl_Texto.SetBinding(Lbl_Texto.Rotation.Pro)
	}

	
}

