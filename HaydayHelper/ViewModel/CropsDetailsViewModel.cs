

namespace HaydayHelper.ViewModel
{
    [QueryProperty("Crops", "_crops")]
   
    public partial class CropsDetailsViewModel : BaseViewModel
    {

        public CropsDetailsViewModel() 
        {
           // this.Title = _Crop.Name;
        }

        [ObservableProperty]
        Crops _crops;

    }

   
}
