using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelServiceAPI.Common.ParsingOperations
{
    public class ParseAddress
    {
        public List<Entities.Address> Parse(List<HotelBookingSystemDataOperations.Address> hotelData)
        {
            List<Entities.Address> addresses = new List<Entities.Address>();

            foreach (HotelBookingSystemDataOperations.Address address in hotelData)
            {
                Entities.Address newAddress = new Entities.Address();
                newAddress.City = address.City;
                newAddress.Locality = address.Locality;
            }
            return addresses;
        }
    }
}