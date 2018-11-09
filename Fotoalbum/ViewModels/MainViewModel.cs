using Fotoalbum.Helpers;
using Fotoalbum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fotoalbum.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(FotoService service)
        {
            this.service = service;
            GetAlbenCommand = new RelayCommand(GetAllAlben);
            GetFotosFromAlbumCommand = new RelayCommand(GetFotosFromAlbum);
            SearchtextChangedCommand = new RelayCommand(FilterAlbum);
        }


        private void FilterAlbum()
        {
            Alben = allAlben.Where(x => x.Title.ToLower().StartsWith(Searchtext.ToLower())).ToList();
        }

        private void GetFotosFromAlbum()
        {
            // Fotos vom ALbum X laden ...
            FotosAusAktuellemAlbum = service.GetAllFotos().Where(x => x.AlbumId == CurrentSelectedAlbum.Id).ToList();
        }

        private void GetAllAlben()
        {
            allAlben = service.GetAllAlben();
            Alben = allAlben;
        }

        private readonly FotoService service;

        private List<Album> allAlben;
        private List<Album> alben;
        public List<Album> Alben
        {
            get => alben;
            set => SetProperty(ref alben, value);
        }

        private List<Foto> fotosAusAktuellemAlbum;
        public List<Foto> FotosAusAktuellemAlbum
        {
            get => fotosAusAktuellemAlbum;
            set => SetProperty(ref fotosAusAktuellemAlbum, value);
        }

        public Album CurrentSelectedAlbum { get; set; }
        public string Searchtext { get; set; }

        public RelayCommand GetFotosFromAlbumCommand { get; set; }
        public RelayCommand GetAlbenCommand { get; set; }
        public RelayCommand SearchtextChangedCommand { get; set; }
    }
}
