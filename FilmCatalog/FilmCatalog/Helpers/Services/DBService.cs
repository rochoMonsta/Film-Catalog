using FilmCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilmCatalog.Helpers.Services
{
    class DBService
    {
        private ApplicationContext _applicationContext;

        public DBService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public User GetUser(string login, string password)
        {
            return _applicationContext.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}
