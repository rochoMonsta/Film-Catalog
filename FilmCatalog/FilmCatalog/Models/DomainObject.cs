using GalaSoft.MvvmLight;

namespace FilmCatalog.Models
{
    public class DomainObject : ViewModelBase
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }
    }
}
