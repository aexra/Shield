using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.ApplicationModel.Resources;
using Shield.App.Helpers;
using Shield.App.ViewModels;

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
        var response = await ApiHelper.TryLogin("awufka", "Lutya1_");
        TB.Text = response ?? "no response";
    }
}
