namespace NetMAUI_Clase2_Calculator;

public enum Operaciones
{
	suma,resta, division, multiplicacion, porcentaje, igual
}

public partial class MainPage : ContentPage
{
	private decimal PrimerTermino;
	private decimal SegundoTermino;
	private string  Operacion;
	private Boolean EstaOperando;
	private Boolean SepuedeBorrar;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Btn_Num_Clicked(object sender, EventArgs e)
    {
		Button btn = (Button)sender;
		
		if (Lbl_Visor.Text.Replace(".", "").Replace("-","").Length == 9) return;  //Hasta 9 dígitos
		if (btn.Text == "0" && Lbl_Visor.Text == "0") return; //Si el visor es 0, y el usuario 0
		if (Lbl_Visor.Text == "0") Lbl_Visor.Text = "";
		if (SepuedeBorrar) Lbl_Visor.Text = "";
		Lbl_Visor.Text += btn.Text;
		SepuedeBorrar = false;
		FormatearVisor();

	}
private void Btn_Operar(object sender, EventArgs e)
    {
		Button btn = (Button)sender;
		
		if (EstaOperando==true)
        {
			SegundoTermino= Decimal.Parse(Lbl_Visor.Text);
			Resolver(ObtenerOperacion(btn.Text));
			return ;
		}

		EstaOperando = true;
		PrimerTermino = Decimal.Parse(Lbl_Visor.Text);
		SepuedeBorrar = true;
	}

	private void Resolver(Operaciones operacion)
    {
        switch (operacion)
        {
            case Operaciones.suma:
				Lbl_Visor.Text = (PrimerTermino + SegundoTermino).ToString();
				break;
            case Operaciones.resta:
				Lbl_Visor.Text = (PrimerTermino - SegundoTermino).ToString();
				break;
            case Operaciones.division:
				Lbl_Visor.Text = (PrimerTermino / SegundoTermino).ToString();
				break;
            case Operaciones.multiplicacion:
				Lbl_Visor.Text = (PrimerTermino * SegundoTermino).ToString();
				break;
            default:
                break;
        }
        EstaOperando = false;
		
		SepuedeBorrar = true;
		FormatearVisor();
	}


	private void Btn_Can_Clicked(object sender, EventArgs e)
	{
		Lbl_Visor.Text = "0";
		EstaOperando = false;
		SepuedeBorrar = true;

	}
	private void Btn_Inv_Clicked(object sender, EventArgs e)
	{
		decimal valor = decimal.Parse(Lbl_Visor.Text.Replace(".", ""));
		Lbl_Visor.Text = (valor * -1).ToString();
		FormatearVisor();
	}
	#region "Funciones Adicionales"

	private Operaciones ObtenerOperacion(string text)
	{
		Operaciones operacion = Operaciones.suma;
		switch (text)
		{
			case "X":
				operacion = Operaciones.multiplicacion;
				break;
			case "-":
				operacion = Operaciones.resta;
				break;
			case "÷":
				operacion = Operaciones.porcentaje;
				break;
		}
		return operacion;
	}

	private void FormatearVisor()
	{
		Lbl_Visor.Text = String.Format("{0:n0}", Decimal.Parse(Lbl_Visor.Text));
	}
	#endregion

	private void Resolver(object sender, EventArgs e)
	{

	}
}

