using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLaba1Frame
{
    public class City
    {
        public string CityName { get; set; }
        public int CityId { get; set; }

        public City(string Name, int Id)
        {
            CityName = Name;
            CityId = Id;
        }

        public override string ToString()
        {
            return $"{CityName,15} {CityId,3}";
        }
    }
}
