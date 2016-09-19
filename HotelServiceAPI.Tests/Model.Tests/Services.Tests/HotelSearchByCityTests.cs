using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelServiceAPI;
using HotelServiceAPI.Model.Services;

namespace HotelServiceAPI.Tests
{
    [TestClass]
    public class HotelSearchByCityTests
    {
        [TestMethod]
        public void GetHotelsTestByCityName()
        {
            HotelSearchByCityName hotelSearchByCity = new HotelSearchByCityName();
            hotelSearchByCity.CityName = "goa";

            HotelResponse hotelResponse = hotelSearchByCity.GetHotels();

            Assert.IsNull(hotelResponse.HotelStatus);

            Assert.IsNotNull(hotelResponse.Hotels);

        }


        [TestMethod]
        public void GetHotelsTranslate()
        {
            HotelSearchByCityName hotelSearchByCity = new HotelSearchByCityName();

            HotelResponse hotelResponse = hotelSearchByCity.GetHotels();

            Assert.IsNull(hotelResponse.HotelStatus);

            Assert.IsNotNull(hotelResponse.Hotels);
        }
    }
}
