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
        private List<MainViewModel> createdInstances = new List<MainViewModel>();
        public MainViewModel GetMainViewModel
        {
            get
            {
                createdInstances.Add(new MainViewModel(service));
                return createdInstances[createdInstances.Count - 1];
            }
        }

        public void CleanUp()
        {
            foreach (var item in createdInstances)
            {
                // item.Dispose();

                // Alternative: Properties manuell leeren und danach:

                // GC.Collect();
            }
        }
    }
}
