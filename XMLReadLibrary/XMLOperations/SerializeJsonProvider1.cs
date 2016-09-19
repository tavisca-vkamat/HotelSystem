using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using XMLReadLibrary.XMLClasses.ProviderOne;

namespace XMLReadLibrary.XMLOperations
{
    public class SerializeJsonProvider1
    {
        public Hotel_Data ReadJson()
        {



            JavaScriptSerializer oJS = new JavaScriptSerializer();
            StreamReader sr = new StreamReader(Property.DataProviderJsonOne);
            string jsonString = sr.ReadToEnd();
            var oRootObject = JsonConvert.DeserializeObject<Rootobject>(jsonString);

            Hotel_Data hotelData = new Hotel_Data();



            hotelData.hotel_0 = oRootObject.getHotelRatesLiveNet.results.hotel_data.hotel_0;

            hotelData.hotel_1 = oRootObject.getHotelRatesLiveNet.results.hotel_data.hotel_1;

            hotelData.hotel_2 = oRootObject.getHotelRatesLiveNet.results.hotel_data.hotel_2;



            //string str = oRootObject.GetType().ToString();
            //StreamReader sr = new StreamReader(@"D:\\training\\WCF\\XMLHotelAPI\\Data\\RS_f370dfb6-e226-4c9a-92f2-35b79e90c6b7.txt");
            //string jsonString = sr.ReadToEnd();
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Rootobject));
            //MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            //Rootobject obj = (Rootobject)ser.ReadObject(ms);
            //return obj;



            //StreamReader sr = new StreamReader(@"D:\\training\\WCF\\XMLHotelAPI\\Data\\RS_f370dfb6-e226-4c9a-92f2-35b79e90c6b7.JSON");
            //string jsonString = sr.ReadToEnd();
            //object obj = JsonConvert.DeserializeObject<Hotel_Data>(jsonString);

            return hotelData;
        }
    }
}
