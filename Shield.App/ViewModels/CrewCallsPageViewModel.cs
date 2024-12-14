using System.Collections.ObjectModel;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Shield.App.Helpers;
using Shield.DataAccess.DTOs;

namespace Shield.App.ViewModels;
public class CrewCallsPageViewModel : ObservableObject
{
    public ObservableCollection<CrewCallDto> Calls = new();

    public async Task LoadCalls(int crewId)
    {
        Calls.Clear();

        var response = await ApiHelper.GetCrewCalls(crewId);

        if (response != null && response.IsSuccessStatusCode)
        {
            var list = await response.Content.ReadFromJsonAsync<List<CrewCallDto>>();

            foreach (var call in list)
            {
                Calls.Add(call);
            }
        }
    }
}
