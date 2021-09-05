using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace FilmCatalog.ViewModels
{
    class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<UserFilmsViewModel>();
            SimpleIoc.Default.Register<AuthorizationViewModel>();
        }

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public UserFilmsViewModel UserFilmsViewModel => ServiceLocator.Current.GetInstance<UserFilmsViewModel>();

        public AuthorizationViewModel AuthorizationViewModel => ServiceLocator.Current.GetInstance<AuthorizationViewModel>();
    }
}
