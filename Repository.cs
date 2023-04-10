using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppLaba1Frame
{
    public class Repository
    {
        static Random r;

        static Repository() { r = new Random(); }

        public List<Zapros> ZaprosDb { get; set; }
        public List<Country> CountryDb { get; set; }
        public List<Cybject> CybjectDb { get; set; }
        public List<City> CityDb { get; set; }
        public List<Sight> SightDb { get; set; }

        private Repository(int Count, int CountEmployee)
        {
            ZaprosDb = new List<Zapros>();
            CountryDb = new List<Country>();
            CybjectDb = new List<Cybject>();
            CityDb = new List<City>();
            SightDb = new List<Sight>();

            for (int i = 0; i < Count; i++)
            {
                
                
                
                SightDb.Add(new Sight($"Sight {i + 1}", i));
            }
            CountryDb.Add(new Country("Россия",1));
            CybjectDb.Add(new Cybject("Москваская область", 1));
            CityDb.Add(new City("Москва", 1));
            CybjectDb.Add(new Cybject("Краснодарский край", 2));
            CityDb.Add(new City("Краснодар", 2));
            CityDb.Add(new City("Сочи", 4));
            CybjectDb.Add(new Cybject("Крым", 3));
            CityDb.Add(new City("Севастополь", 3));
            

            for (int i = 0; i < CountEmployee; i++)
            {
                int SightID = r.Next(SightDb.Count);
                ZaprosDb.Add(
                        new Zapros(r.Next(CountryDb.Count),
                                     r.Next(CybjectDb.Count),
                                     r.Next(CityDb.Count),
                                     SightID));
                SightDb.Remove(SightDb[SightID]);
                
                //SightDb.RemoveAt(SightDb.IndexOf();
            }

            //for (int i = 0; i < Count; i++)
            //{
            //    CountryDb.Add(new Country($"Country {i + 1}", i));
            //    CybjectDb.Add(new Cybject($"Cybject {i + 1}", i));
            //    CityDb.Add(new City($"City {i + 1}", i));
            //    SightDb.Add(new Sight($"Sight {i + 1}", i));
            //}



            //for (int i = 0; i < CountEmployee; i++)
            //{
            //    ZaprosDb.Add(
            //            new Zapros(r.Next(CountryDb.Count),
            //                         r.Next(CybjectDb.Count),
            //                         r.Next(CityDb.Count),
            //                         r.Next(SightDb.Count)));
            //}

        }


        public static Repository CreateRepository(int Count = 10, int CountEmployee = 10)
        {
            return new Repository(Count, CountEmployee);
        }

    }
}
