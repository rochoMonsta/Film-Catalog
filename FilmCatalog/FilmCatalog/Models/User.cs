using System.Collections.Generic;

namespace FilmCatalog.Models
{
    public class User : DomainObject
    {
        private string _login;
        private string _password;
        private string _userName;
        private bool _isActive = true;

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

        public bool IsActive
        {
            get => _isActive;
            set => Set(ref _isActive, value);
        }

        public virtual HashSet<UserFilms> UserFilms { get; set; }
        //public virtual HashSet<Friends> UserFriends { get; set; }

        public User()
        {
            UserFilms = new HashSet<UserFilms>();
            //UserFriends = new HashSet<Friends>();
        }
    }
}
