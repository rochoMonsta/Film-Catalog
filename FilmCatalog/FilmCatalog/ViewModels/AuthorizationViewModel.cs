using FilmCatalog.Helpers;
using FilmCatalog.Helpers.Interfaces;
using FilmCatalog.Helpers.Services;
using FilmCatalog.Models;
using GalaSoft.MvvmLight;
using System.Windows;

namespace FilmCatalog.ViewModels
{
    class AuthorizationViewModel : ViewModelBase, IBaseViewModel
    {
        private bool _isSuccessd = false;
        private string _userLogin;
        private string _userPassword;
        private string _confrimUserPassword;
        private RelayCommand _loginCommand;
        private RelayCommand _registerCommand;
        private ApplicationContext _applicationContext;
        private DBService _dataBaseService;
        public DataStore DataStore { get; set; }

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

        public string ConfrimUserPassword
        {
            get => _confrimUserPassword;
            set => Set(ref _confrimUserPassword, value);
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

        public RelayCommand LoginCommand => _loginCommand ?? (_loginCommand = new RelayCommand(LoginUser));

        public RelayCommand RegisterCommand => _registerCommand ?? (_registerCommand = new RelayCommand(RegisterUser));

        private void LoginUser(object obj)
        {
            var user = _dataBaseService.GetUser(UserLogin, UserPassword);

            if (user != null)
            {
                IsSuccessd = true;
                DataStore.GetDataStore().CurrentUser = user;
            }
        }

        private void RegisterUser(object obj)
        {
            if (UserPassword.ToLower() == ConfrimUserPassword.ToLower())
            {
                if (_dataBaseService.RegisterUser(UserLogin, UserPassword))
                {
                    var user = _dataBaseService.GetUser(UserLogin, UserPassword);

                    if (user != null)
                    {
                        IsSuccessd = true;
                        DataStore.GetDataStore().CurrentUser = user;
                    }
                }
            }
        }

        private void ClearData()
        {
            UserLogin = null;
            UserPassword = null;
            ConfrimUserPassword = null;
        }

        public void GetData()
        {
            ClearData();
        }

        public void SaveData()
        {
            throw new System.NotImplementedException();
        }

        public void DiscardData()
        {
            throw new System.NotImplementedException();
        }
    }
}
