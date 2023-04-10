using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLaba1Frame
{
    class Jason
    {
        #region SerializeClientsList
        public void SerializeClientsList(List<Zapros> СoncreteClientsList, string Path)
        {

            string json = JsonConvert.SerializeObject(СoncreteClientsList);

            File.WriteAllText(Path, json);

        }
        #endregion


        #region DeserializeClientsList
        public List<Zapros> DeserializeClientsList(string Path)
        {
            string json = File.ReadAllText(Path);

            List<Zapros> list = new List<Zapros>();
            list = JsonConvert.DeserializeObject<List<Zapros>>(json);


            return list;
        }
        #endregion
    }
}
