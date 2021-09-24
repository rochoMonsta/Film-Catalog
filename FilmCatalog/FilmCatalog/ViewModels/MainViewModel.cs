using FilmCatalog.Helpers;
using FilmCatalog.Helpers.Interfaces;
using FilmCatalog.Models;
using GalaSoft.MvvmLight;
using System;
using System.Windows;

namespace FilmCatalog.ViewModels
{
    class MainViewModel : ViewModelBase, IBaseViewModel
    {
        public Action OnLogout;

        private IBaseViewModel _selectedViewModel;
        private RelayCommand _updateViewCommand;
        private RelayCommand _friendsViewCommand;
        private RelayCommand _shutDownApplicationCommand;
        private RelayCommand _logoutCommand;
        private User _currentUser;

        public User CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

        public IBaseViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                Set(ref _selectedViewModel, value);

                if (value != null)
                {
                    value.GetData();
                }
            }
        }

        public MainViewModel()
        {
            CurrentUser = DataStore.GetDataStore().CurrentUser;
        }

        public RelayCommand UpdateViewCommand
        {
            get
            {
                return _updateViewCommand ?? (
                    _updateViewCommand = new RelayCommand(SetHomePage)
                    );
            }
        }

        public RelayCommand FriendsViewComman
        {
            get
            {
                return _friendsViewCommand ?? (
                     _friendsViewCommand = new RelayCommand(SetFriednsPage)
                     );
            }
        }

        public RelayCommand ShutDownApplicationCommand
        {
            get
            {
                return _shutDownApplicationCommand ?? (
                    _shutDownApplicationCommand = new RelayCommand((object obj) => Application.Current.Shutdown())
                    );
            }
        }

        public RelayCommand LogoutCommand
        {
            get
            {
                return _logoutCommand ?? (
                    _logoutCommand = new RelayCommand((object obj) => OnLogout?.Invoke())
                    );
            }
        }

        private void SetHomePage(object commandParameter) => SelectedViewModel = new UserFilmsViewModel();
        private void SetFriednsPage(object commandParameter) => SelectedViewModel = new FriednsViewModel();

        public void GetData()
        {
            CurrentUser = DataStore.GetDataStore().CurrentUser;
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }

        public void DiscardData()
        {
            throw new NotImplementedException();
        }

        public void ClearData()
        {
            throw new NotImplementedException();
        }
    }
}
