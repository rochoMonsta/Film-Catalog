using GalaSoft.MvvmLight;

namespace FilmCatalog.Models
{
    class DomainObject : ViewModelBase
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }
    }
}
