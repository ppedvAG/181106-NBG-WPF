using MVVMSimpel.Helpers;
using MVVMSimpel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSimpel.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Controllfreak-Antipattern
            service = new PersonenService();
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }
        private void GetPersonen()
        {
            Personenliste = service.GetPersonen();
        }

        private readonly PersonenService service;

        private List<Person> personenListe;
        public List<Person> Personenliste
        {
            get => personenListe;
            set => SetProperty(ref personenListe, value);
        }
        public RelayCommand GetPersonenCommand { get; set; }
    }
}
