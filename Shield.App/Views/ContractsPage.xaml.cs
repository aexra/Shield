using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.ApplicationModel.Resources;
using Shield.App.Helpers;
using Shield.App.ViewModels;
using Shield.DataAccess.DTOs;
using Windows.Storage;

namespace Shield.App.Views;

public sealed partial class ContractsPage : Page
{
    public ContractsViewModel ViewModel
    {
        get;
    }

    public ContractsPage()
    {
        ViewModel = App.GetService<ContractsViewModel>();
        InitializeComponent();
    }

    private async void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        //var response = await ApiHelper.TryLogin("awufka", "Lutya1_");

        //if (response != null)
        //{
        //    if (response is Exception ex)
        //    {
        //        TB.Text = ex.Message;
        //        if (ex.InnerException != null)
        //        {
        //            TB.Text += "\n" + ex.InnerException.Message;
        //        }
        //    }
        //    else if (response is LoginResponseDto dto)
        //    {

        //    }
        //}

        //TB.Text = (string?)ApplicationData.Current.LocalSettings.Values["apiToken"];

        TB.Text = string.Join("\n", (await ApiHelper.GetAllContracts()).Contracts.Select(c => $"ID={c.Id}\nAddress={c.Address}\nOwners={c.Owners}\nBailee={c.Bailee}"));
    }
}
