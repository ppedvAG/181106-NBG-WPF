using Fotoalbum.Models;
using Fotoalbum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotoalbum.Helpers
{
    public class ViewModelLocator
    {

        private FotoService service = new FotoService();
        // Variante: Mehrere Fenster = Mehrere instanzen des selben ViewModels
        public MainViewModel GetMainViewModel => new MainViewModel(service);
    }
}
