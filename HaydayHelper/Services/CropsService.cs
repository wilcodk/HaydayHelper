

using System.Net.Http.Json;

namespace HaydayHelper.Services
{
    public class CropsService
    {
        HttpClient httpClient;
        List<Crops> CropsList = new List<Crops>();

        public CropsService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Crops>> GetCrops()
        {
            if (CropsList?.Count > 0)
                return CropsList;

            var url = "https://raw.githubusercontent.com/wilcodk/HaydayHelper/main/crops.json";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                CropsList = await response.Content.ReadFromJsonAsync<List<Crops>>();

            }

            return CropsList;

        }
    }
}
