using HotelBookingSystemDataOperations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelServiceAPI.Common.ParsingOperations
{
    public class ParseHotel
    {
        // parse database hotel object to entity hotel object
        public List<Entities.Hotel> Parse(List<HotelData> hotelData)
        {
            List<Entities.Hotel> hotels = new List<Entities.Hotel>();

            foreach(HotelData hotel in hotelData)
            {
                Entities.Hotel newHotel = new Entities.Hotel();

                newHotel.Id = hotel.Id;
                newHotel.Name = hotel.Name;
                newHotel.Rating = (float)hotel.Rating;
                newHotel.PhoneNumber = hotel.PhoneNumber;
                newHotel.Address = new Entities.Address();
                newHotel.Address.Locality = hotel.Locality;
                newHotel.Address.City = hotel.City;
                newHotel.Rate = new Entities.Rate();
                newHotel.Rate.Minimum = hotel.MinRate;
                newHotel.Rate.Maximum = hotel.MaxRate;
                hotels.Add(newHotel);
            }
            return hotels;
        }
    }
}