using FilmCatalog.Models;
using GalaSoft.MvvmLight;

namespace FilmCatalog.Helpers
{
    class DataStore : ViewModelBase
    {
        private static DataStore _dataStore;
        private User _currentUser;

        public User CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

        private DataStore()
        {

        }

        public static DataStore GetDataStore()
        {
            if (_dataStore == null)
            {
                _dataStore = new DataStore();
            }

            return _dataStore;
        }
    }
}
