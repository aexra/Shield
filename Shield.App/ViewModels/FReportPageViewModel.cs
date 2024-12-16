using System.Collections.ObjectModel;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Shield.App.Helpers;
using Shield.DataAccess.DTOs;

namespace Shield.App.ViewModels;
public class FReportPageViewModel : ObservableObject
{
    public ObservableCollection<Report1> Data1 { get; set; } = new();
    public ObservableCollection<Report2> Data2 { get; set; } = new();
    public ObservableCollection<Report3> Data3 { get; set; } = new();

    public async Task LoadData()
    {
        Data1.Clear();
        Data2.Clear();
        Data3.Clear();

        var response1 = await ApiHelper.GetReport(1);

        System.Diagnostics.Debug.WriteLine(response1.IsSuccessStatusCode);

        if (response1 != null && response1.IsSuccessStatusCode)
        {
            var list = await response1.Content.ReadFromJsonAsync<List<Report1>>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Data1.Add(item);
                }
            }
        }

        var response2 = await ApiHelper.GetReport(2);

        System.Diagnostics.Debug.WriteLine(response2.IsSuccessStatusCode);

        if (response2 != null && response2.IsSuccessStatusCode)
        {
            var list = await response2.Content.ReadFromJsonAsync<List<Report2>>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Data2.Add(item);
                }
            }
        }

        var response3 = await ApiHelper.GetReport(3);

        System.Diagnostics.Debug.WriteLine(response3.IsSuccessStatusCode);

        if (response3 != null && response3.IsSuccessStatusCode)
        {
            var list = await response3.Content.ReadFromJsonAsync<List<Report3>>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Data3.Add(item);
                }
            }
        }
    }
}
