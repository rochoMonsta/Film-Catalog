using System.Collections.Generic;

namespace FilmCatalog.Models
{
    class User : DomainObject
    {
        private string _login;
        private string _password;
        private string _userName;

        public string Login
        {
            get => _login;
            set => Set(ref _login, value);
        }

        public string Password
        {
            get => _password;
            set => Set(ref _password, value);
        }

        public string UserName
        {
            get => _userName;
            set => Set(ref _userName, value);
        }

        public HashSet<UserFilms> UserFilms { get; set; }

        public User()
        {
            UserFilms = new HashSet<UserFilms>();
        }
    }
}
