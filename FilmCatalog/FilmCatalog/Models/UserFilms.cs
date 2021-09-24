namespace FilmCatalog.Models
{
    public class UserFilms : DomainObject
    {
        private int _userId;
        private int _filmId;

        public int UserId
        {
            get => _userId;
            set => Set(ref _userId, value);
        }

        public int FilmId
        {
            get => _filmId;
            set => Set(ref _filmId, value);
        }

        public virtual User User { get; set; }

        public virtual Film Film { get; set; }
    }
}
