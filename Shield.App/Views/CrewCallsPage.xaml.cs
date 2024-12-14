using Microsoft.UI.Xaml.Controls;
using Shield.App.ViewModels;

namespace Shield.App.Views;
public sealed partial class CrewCallsPage : Page
{
    public CrewCallsPageViewModel ViewModel { get; set; }

    public CrewCallsPage()
    {
        ViewModel = App.GetService<CrewCallsPageViewModel>();
        this.InitializeComponent();
    }

    private async void SearchButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        if (int.TryParse(IdTextBox.Text, out var id))
        {
            await ViewModel.LoadCalls(id);
        }
    }
}
