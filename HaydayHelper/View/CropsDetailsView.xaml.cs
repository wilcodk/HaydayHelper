namespace HaydayHelper.View;


public partial class CropsDetailsView : ContentPage
{
	
	public CropsDetailsView(CropsDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;	
	}
}