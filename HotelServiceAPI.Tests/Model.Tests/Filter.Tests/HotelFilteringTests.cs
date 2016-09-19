using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelServiceAPI.Model.Filter;
using HotelServiceAPI.Common.Entities;
using System.Collections.Generic;
using HotelServiceAPI.Model.Services;

namespace HotelServiceAPI.Tests.Model.Tests.Filter.Tests
{
    [TestClass]
    public class HotelFilteringTests
    {
        [TestMethod]
        public void HotelFilterByRatingTests()
        {
            HotelSearchByCityName hotelSearchByCity = new HotelSearchByCityName();
            hotelSearchByCity.CityName = "goa";

            HotelResponse hotelResponse = hotelSearchByCity.GetHotels();

            int count = hotelResponse.Hotels.Count;

            HotelFilters hotelFilter = new HotelFilters();

            hotelFilter.FilterByRating(hotelResponse.Hotels,"4");

            Assert.AreNotEqual(hotelResponse.Hotels.Count,count);
        }
    }
}
