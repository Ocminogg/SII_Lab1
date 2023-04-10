using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLaba1Frame
{
    public class Cybject
    {
        public string CybjectName { get; set; }
        public int CybjectId { get; set; }

        public Cybject(string Name, int Id)
        {
            CybjectName = Name;
            CybjectId = Id;
        }

        public override string ToString()
        {
            return $"{CybjectName,15} {CybjectId,3}";
        }
    }
}
