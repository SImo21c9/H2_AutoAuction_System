using Auto_Auction.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class VehiclePropertyControl : UserControl
{
    public VehiclePropertyControl()
    {
        InitializeComponent();
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (DataContext is VehiclePropertyControlViewModel vm && sender is ComboBox cb)
        {
            vm.BusVisble = false;
            vm.PrivCarVisble = false;
            vm.ProCarVisble = false;
            vm.TruckVisible = false;

            if (cb.SelectedItem is ComboBoxItem item && item.Content is string selected)
            {
                switch (selected)
                {
                    case "Truck":
                        vm.TruckVisible = true;
                        break;
                    case "PrivateCar":
                        vm.PrivCarVisble = true;
                        break;
                    case "Bus":
                        vm.BusVisble = true;
                        break;
                    case "ProfessionCar":
                        vm.ProCarVisble = true;
                        break;
                }
            }
        }
    }
}