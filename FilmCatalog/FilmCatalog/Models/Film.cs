using System.Collections.Generic;

namespace FilmCatalog.Models
{
    public class Film : DomainObject
    {
        private string _name;
        private string _description;
        private double _mark;
        private string _director;

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        public string Director
        {
            get => _director;
            set => Set(ref _director, value);
        }

        public double Mark
        {
            get => _mark;
            set => Set(ref _mark, value);
        }

        public HashSet<UserFilms> UserFilms { get; set; }

        public Film()
        {
            UserFilms = new HashSet<UserFilms>();
        }
    }
}
