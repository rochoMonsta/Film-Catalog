using System;
using System.Collections.Generic;
using System.Text;

namespace FilmCatalog.Helpers.Interfaces
{
    interface IBaseViewModel
    {
        public void GetData();
        public void SaveData();
        public void DiscardData();
        public void ClearData();
    }
}
