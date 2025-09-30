using System;
using Auto_Auction.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;



namespace Auto_Auction.Controls
{
    
    public partial class LoginView : UserControl
    {
        private MainWindow _mainWindow;
        
        public LoginView(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        public async void OnLoginClick(object? sender, RoutedEventArgs e)
        {
            var username = UsernameBox.Text?.Trim();
            var password = PasswordBox.Text?.Trim();
        
            if (string.IsNullOrEmpty(username))
            {
                await MessageBoxManager
                    .GetMessageBoxStandard("Error", "Username is required.")
                    .ShowAsync();
                Console.WriteLine("Username is required.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                await MessageBoxManager
                    .GetMessageBoxStandard("Error", "Password is required.")
                    .ShowAsync();
                Console.WriteLine("Password is required.");
                
                return;
            }

            // 2. Fake login check replace later with real authentication
            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login successful!");
                NavigateToDashboard();
            }
            else
            {
                await MessageBoxManager
                    .GetMessageBoxStandard("Error", "Invalid username or password.")
                    .ShowAsync();
                Console.WriteLine("Invalid username or password.");
            }
        
            //check if works
            Console.WriteLine($"Login clicked with username: {username} and password: {password}");
        }
        private void NavigateToDashboard()
        {
            _mainWindow.NavigateToDashboard();
        }
    }
}