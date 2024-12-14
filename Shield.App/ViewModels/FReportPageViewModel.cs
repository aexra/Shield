using System.Collections.ObjectModel;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Shield.App.Helpers;
using Shield.DataAccess.Models;

namespace Shield.App.ViewModels;
public class FReportPageViewModel : ObservableObject
{
    public ObservableCollection<Keyless> Data { get; set; } = new();

    public async Task LoadData()
    {
        var response = await ApiHelper.GetReport(1);

        if (response != null && response.IsSuccessStatusCode)
        {
            var list = await response.Content.ReadFromJsonAsync<List<Keyless>>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Data.Add(item);
                }
            }
        }
    }
}
