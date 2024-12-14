using Microsoft.UI.Xaml.Controls;
using Shield.App.ViewModels;

namespace Shield.App.Views;
public sealed partial class FReportPage : Page
{
    public FReportPageViewModel ViewModel { get; set; }

    public FReportPage()
    {
        ViewModel = App.GetService<FReportPageViewModel>();
        this.InitializeComponent();
    }

    private async void SearchButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        await ViewModel.LoadData();
    }
}
