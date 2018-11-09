using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fotoalbum.Models
{
    public class FotoService
    {
        private List<Foto> fotocache;
        private List<Album> albumcache;
        public List<Foto> GetAllFotos()
        {
            if (fotocache != null)
                return fotocache;

            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://jsonplaceholder.typicode.com/photos").Result;
            }

            fotocache = JsonConvert.DeserializeObject<List<Foto>>(json);
            return fotocache;
        }

        public List<Album> GetAllAlben()
        {
            if (albumcache != null)
                return albumcache;
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://jsonplaceholder.typicode.com/albums").Result;
            }
            albumcache = JsonConvert.DeserializeObject<List<Album>>(json);

            return albumcache;
        }
    }
}
