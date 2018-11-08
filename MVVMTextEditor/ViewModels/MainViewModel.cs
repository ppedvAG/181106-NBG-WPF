using MVVMTextEditor.Helpers;
using MVVMTextEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTextEditor.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            service = new FileService();
            SaveCommand = new RelayCommand(SaveFile);
            LoadCommand = new RelayCommand(LoadFile);
        }

        private void LoadFile()
        {
            Content = service.OpenTextFile();
        }

        private void SaveFile()
        {
            service.SaveTextFile(Content);
        }

        private readonly FileService service;
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand LoadCommand { get; set; }
        private string content;
        public string Content
        {
            get => content;
            set => SetProperty(ref content, value);
        }
    }
}
