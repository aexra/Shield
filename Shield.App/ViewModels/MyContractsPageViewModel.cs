using System.Collections.ObjectModel;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Shield.App.Controls;
using Shield.App.Helpers;
using Shield.DataAccess.DTOs;

namespace Shield.App.ViewModels;
public class MyContractsPageViewModel : ObservableObject
{
    public ObservableCollection<ContractControl> ContractsControls { get; set; } = new();

    public async Task SearchContracts(int userId)
    {
        ContractsControls.Clear();

        var response = await ApiHelper.GetContracts(userId);

        if (response != null && response.IsSuccessStatusCode)
        {
            var dto = await response.Content.ReadFromJsonAsync<List<ContractDto>>();

            if (dto != null)
            {
                foreach (var con in dto)
                {
                    var control = new ContractControl(con);
                    ContractsControls.Add(control);
                }
            }
        }
    }
}
