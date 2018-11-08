using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MVVMSimpel.Model;
using System.Collections.Generic;

namespace MVVMLight_Demo.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IPersonenService service)
        {
            this.service = service;
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }
        private void GetPersonen()
        {
            Personenliste = service.GetPersonen();
        }

        private readonly IPersonenService service;

        private List<Person> personenListe;
        public List<Person> Personenliste
        {
            get => personenListe;
            set => Set(ref personenListe, value);
        }
        public RelayCommand GetPersonenCommand { get; set; }
    }
}