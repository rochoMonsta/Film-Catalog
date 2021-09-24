using FilmCatalog.Helpers;
using FilmCatalog.Helpers.Interfaces;
using FilmCatalog.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilmCatalog.ViewModels
{
    public class FriednsViewModel : ViewModelBase, IBaseViewModel
    {
        public void ClearData()
        {
            throw new NotImplementedException();
        }

        public void DiscardData()
        {
            
        }

        public async void GetData()
        {
            var users = await DataStore.GetDataStore().GenericRepository.GetAll<Friends>();
        }

        public void SaveData()
        {
            
        }
    }
}
