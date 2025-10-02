using Auto_Auction.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class SetForSaleView : UserControl
{
    public SetForSaleView()
    {
        InitializeComponent();
        DataContext = new SetForSaleViewModel();
    }
}