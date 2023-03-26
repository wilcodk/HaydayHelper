

using CommunityToolkit.Mvvm.Input;
using HaydayHelper.Model;
using HaydayHelper.Services;
using HaydayHelper.View;

namespace HaydayHelper.ViewModel
{
    public partial class CropsViewModel : BaseViewModel
    {
        CropsService cropsService;
        public ObservableCollection<Crops> Crops { get; } = new ObservableCollection<Crops>();

        public CropsViewModel(CropsService _cropsService)
        {
            Title = "Hayday helper afgrøder";
            this.cropsService = _cropsService;
        }

        [RelayCommand]
        async Task GoToCropsDetail(Crops crops)
        {
            if (crops is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(CropsDetailsView)}", true,
                new Dictionary<string, object>
                {
                    { "Crops", crops}    
                });
        }

        [RelayCommand]
        async Task GetCropssAsync2()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var crops = await cropsService.GetCrops();

                if (Crops.Count != 0)
                    Crops.Clear();

                foreach (var crop in crops)
                    Crops.Add(crop);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get crops: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }


    }
}
