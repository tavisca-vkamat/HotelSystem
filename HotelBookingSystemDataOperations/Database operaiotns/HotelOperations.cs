using HotelBookingSystemDataOperations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystemDataOperations
{
    public class HotelOperations
    {
        public List<HotelData> SearchByCity(string cityName)
        {
            using (HotelSystemLinqDataContext contex = new HotelSystemLinqDataContext())
            {
                // get hotel ids in city
                AddressOperaions addressOperaions = new AddressOperaions();
                List<string> hotelIds = addressOperaions.GetHotelIds(cityName);
                /* get min rate max rate list of hotels */
                RoomOperations roomOperaions = new RoomOperations();
                Dictionary<string, Rate> rates = roomOperaions.GetRates(hotelIds);
                // select address and hotel details from table
                var hotels = from hotel
                             in contex.Hotels join address in contex.Addresses on hotel.Id equals address.HotelId
                             where hotelIds.Contains(hotel.Id)
                             select new HotelData
                             {
                                 Id = hotel.Id,
                                 Name = hotel.Name,
                                 Rating = hotel.Rating,
                                 PhoneNumber = hotel.PhoneNumber,
                                 City = address.City,
                                 Locality = address.Locality,   
                                 MinRate = rates[hotel.Id].Minimum,
                                 MaxRate = rates[hotel.Id].Maximum
                             };
                return hotels.ToList();
            }
        }
    }
}
