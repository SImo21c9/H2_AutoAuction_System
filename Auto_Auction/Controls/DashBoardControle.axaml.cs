using System;
using Auto_Auction.Views;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class DashBoardControle : UserControl
{
    public DashBoardControle(MainWindow mainWindow)
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}