using MVVMTextEditor.Models;
using MVVMTextEditor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTextEditor.Helpers
{
    class ViewModelLocator
    {

        private FileService service;
        public FileService Service
        {
            get
            {
                service = service ?? new FileService();
                return service;
            }
        }

        private MainViewModel main;
        public MainViewModel Main
        {
            get
            {
                main = main ?? new MainViewModel(Service);
                return main;
            }
        }
        // public MainViewModel Main { get; set; }
        // public MainViewModel Main { get; set; }
        // public MainViewModel Main { get; set; }
    }
}
