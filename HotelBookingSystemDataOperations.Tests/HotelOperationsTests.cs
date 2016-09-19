using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBookingSystemDataOperations;
using System.Collections.Generic;
using HotelBookingSystemDataOperations.Entities;

namespace HotelBookingSystemDataOperations.Tests
{
    [TestClass]
    public class HotelOperationsTests
    {
        [TestMethod]
        public void SearchByCityTest()
        {
            HotelOperations hotelOperation = new HotelOperations();

            List<HotelData> hotels = hotelOperation.SearchByCity("goa");

            Assert.IsNotNull(hotels);
        }
    }
}
