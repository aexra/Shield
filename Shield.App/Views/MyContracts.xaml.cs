using Microsoft.UI.Xaml.Controls;
using Shield.App.ViewModels;

namespace Shield.App.Views;
public sealed partial class MyContractsPage : Page
{
    public MyContractsPageViewModel ViewModel { get; set; }

    public MyContractsPage()
    {
        ViewModel = App.GetService<MyContractsPageViewModel>();
        this.InitializeComponent();
    }

    private async void SearchButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        if (int.TryParse(UserIdTextBox.Text, out var id))
        {
            await ViewModel.SearchContracts(id);
        }
    }
}
