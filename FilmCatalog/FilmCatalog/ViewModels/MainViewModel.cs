using FilmCatalog.Helpers;
using FilmCatalog.Models;
using GalaSoft.MvvmLight;
using System;
using System.Windows;

namespace FilmCatalog.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public Action OnLogout;

        private ViewModelBase _selectedViewModel;
        private RelayCommand _updateViewCommand;
        private RelayCommand _shutDownApplicationCommand;
        private RelayCommand _logoutCommand;
        private User _currentUser;

        public DataStore DataStore { get; set; }

        public User CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

        public ViewModelBase SelectedViewModel
        {
            get => _selectedViewModel;
            set => Set(ref _selectedViewModel, value);
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
    }
}
