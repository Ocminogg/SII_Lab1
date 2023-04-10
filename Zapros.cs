using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLaba1Frame
{
    public class Zapros
    {
        public int CountryId { get; set; }
        public int CybjectId { get; set; }
        public int CityId { get; private set; }
        public int SightId { get; private set; }
        //public int DepartamentName
        //{
        //    get
        //    {

        //    }
        //}

        public Zapros(int countryId, int cybjectId, int cityId, int sightId)
        {
            this.CountryId = countryId;
            this.CybjectId = cybjectId;
            this.CityId = cityId;
            this.SightId = sightId;
        }

        //public override string ToString()
        //{
        //    return $"{Name,7} {Age,3} {DepartamentId,3}";
        //}
    }
}
