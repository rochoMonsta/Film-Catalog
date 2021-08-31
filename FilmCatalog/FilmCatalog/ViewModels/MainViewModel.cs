using FilmCatalog.Helpers;
using FilmCatalog.Models;
using GalaSoft.MvvmLight;
using System.Threading;
using System.Threading.Tasks;

namespace FilmCatalog.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private bool _isStarted = false;
        private int _calculationNumber = 1;

        private RelayCommand _startCalculationCommand;
        private RelayCommand _endCalculationCommand;

        public bool IsStarted
        {
            get => _isStarted;
            set => Set(ref _isStarted, value);
        }

        public int CalculationNumber
        {
            get => _calculationNumber;
            set => Set(ref _calculationNumber, value);
        }

        public RelayCommand StartCalculationCommand
        {
            get
            {
                return _startCalculationCommand ?? (
                    _startCalculationCommand = new RelayCommand(StartCalculationAsync)
                    );
            }
        }

        public RelayCommand EndCalculationCommand
        {
            get
            {
                return _endCalculationCommand ?? (
                    _endCalculationCommand = new RelayCommand(StopCalculation)
                    );
            }
        }

        private async void StartCalculationAsync(object obj)
        {
            IsStarted = true;
            await Task.Run(() => DoCalculation());
        }

        private void StopCalculation(object obj)
        {
            IsStarted = false;
        }

        private void DoCalculation()
        {
            while (IsStarted)
            {
                CalculationNumber++;
                Thread.Sleep(1000);
            }
        }

        public MainViewModel()
        {
            using (var db = new ApplicationContext())
            {
                // do some
            }
        }
    }
}
