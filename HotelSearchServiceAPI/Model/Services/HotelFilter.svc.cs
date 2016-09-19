using HotelServiceAPI.Model.Interfaces;
using System.Collections.Generic;
using HotelServiceAPI.Common.Entities;
using HotelServiceAPI.Model.Filter;

namespace HotelServiceAPI.Model.Services
{
    public class HotelFilter : IHotelFilter
    {
        public List<Hotel> Filter(List<Hotel> hotels, Commons.Entities.HotelFilter filter)
        {
            HotelFilters hotelFilter = new HotelFilters();

            if (filter.Rating != null)
                hotelFilter.FilterByRating(hotels, filter.Rating);

            return hotels;
        }
    }
}
