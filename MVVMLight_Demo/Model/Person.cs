using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSimpel.Model
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }
}
