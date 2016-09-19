using System;
using HotelBookingSystemDataOperations;
using HotelServiceAPI.Common.ParsingOperations;
using System.ServiceModel;
using XMLReadLibrary.XMLOperations;
using HotelServiceAPI.Commons.ParsingOperations;
using System.Collections.Generic;
using System.Threading.Tasks;
using XMLReadLibrary;
using XMLReadLibrary.XMLClasses;

namespace HotelServiceAPI.Model.Services
{
  
    public class HotelSearchByCityName : IHotelSearch
    {

        public string CityName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        /// Returns HotelResponse object which contains hotels by city name search
        public HotelResponse GetHotels()
        {
            //database code
            //HotelResponse hotelResponse = new HotelResponse();
            //HotelOperations hotelOperations = new HotelOperations();
            //try
            //{
            //    ParseHotel hotelParse = new ParseHotel();
            //    hotelResponse.Hotels = hotelParse.Parse(hotelOperations.SearchByCity(CityName));

            //}
            //catch (Exception exception)
            //{
            //    hotelResponse.HotelStatus.IsFailed = true;
            //    hotelResponse.HotelStatus.Errors.Add(exception.ToString());
            //}
            //return hotelResponse;

            //xml code
            //xml read and parse
            HotelResponse hotelResponse = new HotelResponse();
            SerializeOperaionsXML serializeOperaionsXML = new SerializeOperaionsXML();

            TranslateHotel translateHotel = new TranslateHotel();

            Task<SearchResult> tasklistxml = Task<SearchResult>.Factory.StartNew(() => serializeOperaionsXML.ReadXml());

            hotelResponse.Hotels = translateHotel.XMLHotel(tasklistxml.Result);

            //json1 read and parse
            SerializeJsonProvider1 serjson1 = new SerializeJsonProvider1();


          //  hotelResponse.Hotels.AddRange(translateHotel.JSONProviderOneHotel(serjson1.ReadJson()));
            

            //json1 read and parse
            SerializeJsonProvider2 serjson2 = new SerializeJsonProvider2();

            Task<List<Hotelsummary>> tasklistjson = Task<List<Hotelsummary>>.Factory.StartNew(() => serjson2.ReadJson());

            hotelResponse.Hotels.AddRange(translateHotel.JSONProviderTwoHotel(tasklistjson.Result));

            Task[] tasks = { tasklistxml, tasklistjson };
            Task.WaitAll(tasks);

            return hotelResponse;
        }
    }
}
