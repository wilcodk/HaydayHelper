namespace HaydayHelper;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CropsDetailsView), typeof(CropsDetailsView));
	}
}
