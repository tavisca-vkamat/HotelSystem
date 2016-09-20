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

            /*   database code
               HotelResponse hotelResponse = new HotelResponse();
               HotelOperations hotelOperations = new HotelOperations();
               try
               {
                   ParseHotel hotelParse = new ParseHotel();
                   hotelResponse.Hotels = hotelParse.Parse(hotelOperations.SearchByCity(CityName));

               }
               catch (Exception exception)
               {
                   hotelResponse.HotelStatus.IsFailed = true;
                   hotelResponse.HotelStatus.Errors.Add(exception.ToString());
               }
               return hotelResponse;
               */
            //xml code
            //xml read and parse
            List<Task> tasks = new List<Task>();


            HotelResponse hotelResponse = new HotelResponse();
            SerializeOperaionsXML serializeOperaionsXML = new SerializeOperaionsXML();
            SerializeJsonProvider2 serjson2 = new SerializeJsonProvider2();
            TranslateHotel translateHotel = new TranslateHotel();

            var xmlReadtask = Task.Run(() => serializeOperaionsXML.ReadXml());
            tasks.Add(xmlReadtask);
            var jsonReadtask = Task.Run(() => serjson2.ReadJson());
            tasks.Add(jsonReadtask);
            Console.WriteLine("waiting for 20 sec ");
            Task.WaitAll(tasks.ToArray(), 20000);

            if (tasks[tasks.IndexOf(xmlReadtask)].IsCompleted && !tasks[tasks.IndexOf(xmlReadtask)].IsFaulted)
                hotelResponse.Hotels = translateHotel.XMLHotel(xmlReadtask.Result);
            if (tasks[tasks.IndexOf(jsonReadtask)].IsCompleted && !tasks[tasks.IndexOf(jsonReadtask)].IsFaulted)
                hotelResponse.Hotels.AddRange(translateHotel.JSONProviderTwoHotel(jsonReadtask.Result));

            return hotelResponse;
        }
    }
}
