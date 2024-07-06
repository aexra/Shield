using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml.Controls;

namespace Shield.App.Controls;
public sealed partial class ContractControl : UserControl, INotifyPropertyChanged
{
    public int ContractId { get; set; }
    public string Address { get; set; }
    public string PlanSrc { get; set; }
    public string Owners { get; set; }
    public string Bailee { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    
    public ContractControl()
    {
        this.InitializeComponent();
    }

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
