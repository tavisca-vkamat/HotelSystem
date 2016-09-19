using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelServiceAPI.Common.Entities;
using XMLReadLibrary;
using XMLReadLibrary.XMLClasses;
using XMLReadLibrary.XMLClasses.ProviderOne;

namespace HotelServiceAPI.Commons.ParsingOperations
{
    public class TranslateHotel
    {
        internal List<Hotel> XMLHotel(SearchResult searchResult)
        {
            List<Hotel> hotels = new List<Hotel>();

            foreach (HotelListHotel hotel in searchResult.HotelList)
            {
                Hotel newHotel = new Hotel();
                newHotel.Id = hotel.hotelId.ToString();
                newHotel.Name = hotel.name;
                newHotel.PhoneNumber = null;
                newHotel.Rating = (float)hotel.starsLevel;
                newHotel.Address = new Address();
                newHotel.Address.City = hotel.Location.city;
                newHotel.Address.Locality = hotel.Location.location;
                newHotel.Rate = new Rate();
                newHotel.Rate.Minimum = hotel.minAverPrice;
                var occupancies = from room
                                  in hotel.RoomTypes
                                  select room.Occupancies.Occupancy;
                var maximum = occupancies.OrderByDescending(x => x.avrNightPrice).First();

                newHotel.Rate.Maximum = maximum.avrNightPrice;

                hotels.Add(newHotel);
            }

            return hotels;
        }

        //internal IEnumerable<Hotel> JSONProviderOneHotel(Hotel_Data hotel_Data)
        //{
        //    List<Hotel> hotels = new List<Hotel>();

        //    for (int hotel = 0; hotel < 3; hotel++)
        //    {
        //        Hotel_0 response = hotel_Data.hotel_0;


        //        Hotel newHotel = new Hotel();
        //        newHotel.Id = hotel.hotelId.ToString();
        //        newHotel.Name = hotel.name;
        //        newHotel.PhoneNumber = null;
        //        newHotel.Rating = (float)hotel.starsLevel;
        //        newHotel.Address = new Address();
        //        newHotel.Address.City = hotel.Location.city;
        //        newHotel.Address.Locality = hotel.Location.location;
        //        newHotel.Rate = new Rate();
        //        newHotel.Rate.Minimum = hotel.minAverPrice;

        //        hotels.Add(newHotel);
        //    }
        //}

        internal IEnumerable<Hotel> JSONProviderTwoHotel(List<Hotelsummary> list)
        {
            List<Hotel> hotels = new List<Hotel>();

            foreach (var hotel in list)
            {
                Hotel newHotel = new Hotel();

                newHotel.Id = hotel.hotelId.ToString();
                newHotel.Name = hotel.name;
                newHotel.PhoneNumber = null;
                newHotel.Rating = (float)hotel.hotelRating;
                newHotel.Address = new Address();
                newHotel.Address.City = hotel.city;
                newHotel.Address.Locality = hotel.locationDescription;
                newHotel.Rate = new Rate();
                newHotel.Rate.Minimum = (decimal)hotel.lowRate;
                newHotel.Rate.Maximum = (decimal)hotel.highRate;

                hotels.Add(newHotel);
            }

            return hotels;
        }
    }
}