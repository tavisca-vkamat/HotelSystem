using HotelServiceAPI.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelServiceAPI.Model.Filter
{
    public class HotelFilters
    {
        public List<Hotel> FilterByRating(List<Hotel> hotelData,string rating)
        {
            List<Hotel> hotels = new List<Hotel>(hotelData);
            for (int hotel = 0; hotel < hotels.Count();)
            {
                bool flagOfBreak = false;
                if (hotels[hotel].Rating < double.Parse(rating))
                {
                    hotels.Remove(hotels[hotel]);
                    flagOfBreak = true;
                }
                if (!flagOfBreak)
                    hotel++;
            }
            return hotels;
        }
    }
}