using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HotelBookingSystemDataOperations.Tests
{
    [TestClass]
    public class AddressOperationsTests
    {
        [TestMethod]
        public void GetHotelIdsTests()
        {
            AddressOperaions addressOperations = new AddressOperaions();

            List<string> hotelIds =  addressOperations.GetHotelIds("goa");

            Assert.IsNotNull(hotelIds);
        }
    }
}
