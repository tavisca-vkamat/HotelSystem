using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using XMLReadLibrary.XMLClasses;

namespace XMLReadLibrary.XMLOperations
{
    public class SerializeJsonProvider2
    {
        public List<Hotelsummary> ReadJson()
        {
            JavaScriptSerializer oJS = new JavaScriptSerializer();

            StreamReader sr = new StreamReader(Property.DataProviderJsonTwo);
            string jsonString = sr.ReadToEnd();
            var oRootObject = JsonConvert.DeserializeObject<Rootobject>(jsonString);

            List<Hotelsummary> hotelsummey = new List<Hotelsummary>();
            foreach (var item in oRootObject.HotelListResponse.HotelList.HotelSummary)
            {
                hotelsummey.Add(item);
            }

            return hotelsummey;
        }
    }
}
