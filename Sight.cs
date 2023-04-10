using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLaba1Frame
{
    public class Sight
    {
        public string SightName { get; set; }
        public int SightId { get; set; }

        public Sight(string Name, int Id)
        {
            SightName = Name;
            SightId = Id;
        }

        public override string ToString()
        {
            return $"{SightName,15} {SightId,3}";
        }
    }
}
