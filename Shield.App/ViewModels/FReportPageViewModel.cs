using System.Collections.ObjectModel;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Shield.App.Helpers;
using Shield.DataAccess.DTOs;

namespace Shield.App.ViewModels;
public class FReportPageViewModel : ObservableObject
{
    public ObservableCollection<Report1> Data { get; set; } = new();

    public async Task LoadData()
    {
        var response = await ApiHelper.GetReport(1);

        System.Diagnostics.Debug.WriteLine(response.IsSuccessStatusCode);

        if (response != null && response.IsSuccessStatusCode)
        {
            var list = await response.Content.ReadFromJsonAsync<List<Report1>>();

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
