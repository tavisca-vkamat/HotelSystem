using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelServiceAPI.Common.ParsingOperations;
using System.Collections.Generic;
using HotelBookingSystemDataOperations;

namespace HotelServiceAPI.Tests
{
    [TestClass]
    public class ParsingOperaionsTests
    {
        [TestMethod]
        public void ParseHotelTests()
        {
            HotelOperations hotelOperations = new HotelOperations();
            ParseHotel hotelParse = new ParseHotel();

            List<Common.Entities.Hotel> hotels = hotelParse.Parse(hotelOperations.SearchByCity("goa"));

            Assert.IsNotNull(hotels);
        }
    }
}
