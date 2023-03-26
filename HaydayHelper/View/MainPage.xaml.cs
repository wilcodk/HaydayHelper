using HaydayHelper.ViewModel;

namespace HaydayHelper;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(CropsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	
}

