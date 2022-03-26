namespace LoginWithAPI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		WebView P=new WebView();

		MainPage = new Login2Page();//new MainPage();
		
	}
}
