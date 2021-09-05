using FilmCatalog.Helpers;
using FilmCatalog.Helpers.Services;
using FilmCatalog.Models;
using GalaSoft.MvvmLight;
using System.Windows;

namespace FilmCatalog.ViewModels
{
    class AuthorizationViewModel : ViewModelBase
    {
        private bool _isSuccessd = false;
        private string _authorizationHeader = (string)Application.Current.Resources["AuthorizationUserLogin"];
        private string _userLogin;
        private string _userPassword;
        private RelayCommand _loginCommand;
        private ApplicationContext _applicationContext;
        private DBService _dataBaseService;

        public string AuthorizationHeader
        {
            get => _authorizationHeader;
            set => Set(ref _authorizationHeader, value);
        }

        public string UserLogin
        {
            get => _userLogin;
            set => Set(ref _userLogin, value);
        }

        public string UserPassword
        {
            get => _userPassword;
            set => Set(ref _userPassword, value);
        }

        public bool IsSuccessd
        {
            get => _isSuccessd;
            set => Set(ref _isSuccessd, value);
        }


        public AuthorizationViewModel()
        {
            _applicationContext = new ApplicationContext();
            _dataBaseService = new DBService(_applicationContext);
        }

        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (
                    _loginCommand = new RelayCommand(LoginUser)
                    );
            }
        }

        private void LoginUser(object obj)
        {
            var user = _dataBaseService.GetUser(UserLogin, UserPassword);

            if (user != null)
            {
                IsSuccessd = true;
            }
        }
    }
}
