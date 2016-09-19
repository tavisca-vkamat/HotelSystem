using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBookingSystemDataOperations.Entities;
using System.Collections.Generic;

namespace HotelBookingSystemDataOperations.Tests
{
    [TestClass]
    public class RoomOperaionsTests
    {
        [TestMethod]
        public void GetRatesMinMax()
        {
            RoomOperations roomOperaions = new RoomOperations();

            AddressOperaions addressOperations = new AddressOperaions();

            List<string> hotelIds = addressOperations.GetHotelIds("goa");

            Dictionary<string, Rate> rates = roomOperaions.GetRates(hotelIds);

            Assert.IsNotNull(rates);
        }
    }
}
