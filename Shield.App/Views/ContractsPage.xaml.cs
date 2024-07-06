using System.Collections.ObjectModel;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.ApplicationModel.Resources;
using Shield.App.Controls;
using Shield.App.Helpers;
using Shield.App.ViewModels;
using Shield.DataAccess.DTOs;
using Windows.Storage;

namespace Shield.App.Views;

public sealed partial class ContractsPage : Page
{
    private ObservableCollection<ContractControl> contractControls = new();

    public ContractsViewModel ViewModel
    {
        get;
    }

    public ContractsPage()
    {
        ViewModel = App.GetService<ContractsViewModel>();
        InitializeComponent();
    }

    private async void CreateContractBtn_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private async void EditContractBtn_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private async void MoreContractBtn_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private async void UpdateContractsListBtn_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        var response = await ApiHelper.GetAllContracts();

        if (response != null)
        {
            foreach (var contract in response.Contracts)
            {
                contractControls.Add(new(contract));
            }
        }
    }

    private async void DeleteContractBtn_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
