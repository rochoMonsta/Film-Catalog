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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
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
            _authorizationViewModel.UserPassword = passwordLoginBox.Password;
            _authorizationViewModel.LoginCommand.Execute(null);

            if (_authorizationViewModel.IsSuccessd)
            {
                var mainWindow = new MainWindow();
                ((MainViewModel)mainWindow.DataContext).GetData();
                mainWindow.Show();
                this.Close();
            }
        }

        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            _authorizationViewModel.UserPassword = passwordRegisterBox.Password;
            _authorizationViewModel.ConfrimUserPassword = confirmPasswordRegisterBox.Password;
            _authorizationViewModel.RegisterCommand.Execute(null);

            if (_authorizationViewModel.IsSuccessd)
            {
                var mainWindow = new MainWindow();
                ((MainViewModel)mainWindow.DataContext).GetData();
                mainWindow.Show();
                this.Close();
            }
        }

        private void TabControlSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _authorizationViewModel.IsSuccessd = true;
            _authorizationViewModel.ClearData();
            passwordLoginBox.Password = null;
            passwordRegisterBox.Password = null;
            confirmPasswordRegisterBox.Password = null;
        }
    }
}
