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
    public ContractsViewModel ViewModel
    {
        get;
    }

    public ContractsPage()
    {
        ViewModel = App.GetService<ContractsViewModel>();
        InitializeComponent();
    }

    private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var lv = (ListView)sender;
        var si = lv.SelectedItem;
        
    }
}
