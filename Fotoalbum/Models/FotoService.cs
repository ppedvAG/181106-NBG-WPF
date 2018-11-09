using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fotoalbum.Models
{
    class FotoService
    {
        public List<Foto> GetAllFotos()
        {
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://jsonplaceholder.typicode.com/photos").Result;
            }

            return JsonConvert.DeserializeObject<List<Foto>>(json);
        }
    }
}
