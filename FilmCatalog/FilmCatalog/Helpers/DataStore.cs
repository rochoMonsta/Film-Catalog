using FilmCatalog.Models;
using GalaSoft.MvvmLight;

namespace FilmCatalog.Helpers
{
    class DataStore : ViewModelBase
    {
        private static DataStore _dataStore;
        private User _currentUser;
        private GenericRepository _genericRepository;

        public User CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

        public GenericRepository GenericRepository
        {
            get => _genericRepository;
            set => Set(ref _genericRepository, value);
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
