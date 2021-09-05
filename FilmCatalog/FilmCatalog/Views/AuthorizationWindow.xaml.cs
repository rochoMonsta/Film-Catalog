using FilmCatalog.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace FilmCatalog.Views
{
    public partial class AuthorizationWindow : Window
    {
        private AuthorizationViewModel _authorizationViewModel;
        public AuthorizationWindow()
        {
            InitializeComponent();
            _authorizationViewModel = (AuthorizationViewModel)DataContext;
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            _authorizationViewModel.UserPassword = passwordBox.Password;
            _authorizationViewModel.LoginCommand.Execute(null);

            if (_authorizationViewModel.IsSuccessd)
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
