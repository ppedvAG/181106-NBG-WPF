using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVMSimpel.Model
{
    public class PersonenService : IPersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname = "Tom", Nachname="Ate", Alter=10,Kontostand=100m},
                new Person{Vorname = "Anna", Nachname="Nass", Alter=20,Kontostand=200m},
                new Person{Vorname = "Peter", Nachname="Silie", Alter=30,Kontostand=3000m},
                new Person{Vorname = "Franz", Nachname="Ose", Alter=40,Kontostand=400m},
                new Person{Vorname = "Martha", Nachname="Pfahl", Alter=50,Kontostand=-500m},
                new Person{Vorname = "Rainer", Nachname="Zufall", Alter=60,Kontostand=6000000m},
                new Person{Vorname = "Klara", Nachname="Fall", Alter=70,Kontostand=77700m},
                new Person{Vorname = "Anna", Nachname="Bolika", Alter=80,Kontostand=-888800m},
                new Person{Vorname = "Frank N", Nachname="Stein", Alter=90,Kontostand=9999900m},
                new Person{Vorname = "Axel", Nachname="Schweiß", Alter=100,Kontostand=-1239999900m}
            };
        }

        #region LINQ
        public void LINQBeispiel()
        {
            var personen = new List<Person>
            {
                new Person{Vorname = "Tom", Nachname="Ate", Alter=10,Kontostand=100m},
                new Person{Vorname = "Anna", Nachname="Nass", Alter=20,Kontostand=200m},
                new Person{Vorname = "Peter", Nachname="Silie", Alter=30,Kontostand=3000m},
                new Person{Vorname = "Franz", Nachname="Ose", Alter=40,Kontostand=400m},
                new Person{Vorname = "Martha", Nachname="Pfahl", Alter=50,Kontostand=-500m},
                new Person{Vorname = "Rainer", Nachname="Zufall", Alter=60,Kontostand=6000000m},
                new Person{Vorname = "Klara", Nachname="Fall", Alter=70,Kontostand=77700m},
                new Person{Vorname = "Anna", Nachname="Bolika", Alter=80,Kontostand=-888800m},
                new Person{Vorname = "Frank N", Nachname="Stein", Alter=90,Kontostand=9999900m},
                new Person{Vorname = "Axel", Nachname="Schweiß", Alter=100,Kontostand=-1239999900m}
            };


            // Gib mir eine Liste aller Vornamen von Personen zurück, die älter als 20 sind

            List<string> alleÄlterAls20 = new List<string>();
            foreach (var item in personen)
            {
                if (item.Alter > 20)
                    alleÄlterAls20.Add(item.Vorname);
            }

            // SELECT -> Ausgabe
            var result = personen.Select(x => x.Vorname).ToList();
            // WHERE -> Bedingung
            alleÄlterAls20 = personen.Where(x => x.Alter > 20)
                                     .Select(x => x.Vorname)
                                     .ToList();

            // OrderBy, Aggregate, First, 

        }

        #endregion

    }
}
