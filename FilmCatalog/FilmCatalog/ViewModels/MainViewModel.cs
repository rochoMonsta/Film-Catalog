using FilmCatalog.Helpers;
using GalaSoft.MvvmLight;

namespace FilmCatalog.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        private RelayCommand _updateViewCommand;

        public ViewModelBase SelectedViewModel
        {
            get => _selectedViewModel;
            set => Set(ref _selectedViewModel, value);
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

        private void SetHomePage(object commandParameter) => SelectedViewModel = new UserFilmsViewModel();
    }
}
