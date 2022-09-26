using PokeAPI.View;

namespace PokeAPI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

     

    }

    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);

        // Cancel any back navigation.
        if (args.Source == ShellNavigationSource.Pop)
        {
            args.Cancel();
        }
        // }

    }
}
