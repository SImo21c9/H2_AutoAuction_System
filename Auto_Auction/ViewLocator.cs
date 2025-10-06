using System;
using Auto_Auction.Controls;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Auto_Auction.ViewModels;

namespace Auto_Auction;

public class ViewLocator : IDataTemplate
{
    public Control Build(object data)
    {
        var name = data.GetType().FullName!.Replace("ViewModel", "View");
        var type = Type.GetType(name);

        if (type != null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }
        
        return data switch
        {
            LoginWindowViewModel => new LoginView(),
            DashBoardViewModel => new DashBoardControle(null),
            CreateUserViewModel => new CreateUserView(),
            SetForSaleViewModel => new SetForSaleView(),
            BuyerofAuctionViewModel => new BuyerofAuctionView(),
            BidHistoryViewModel => new BidHistoryView(),
            _ => new TextBlock { Text = "Not Found: " + name }
        };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}