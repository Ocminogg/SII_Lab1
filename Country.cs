using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLaba1Frame
{
    public class Country
    {
        public string CountryName { get; set; }
        public int CountryId { get; set; }

        public Country(string Name, int Id)
        {
            CountryName = Name;
            CountryId = Id;
        }

        public override string ToString()
        {
            return $"{CountryName,15} {CountryId,3}";
        }
    }
}
