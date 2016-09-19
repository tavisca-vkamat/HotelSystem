using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystemDataOperations
{
    public class AddressOperaions
    {
        // returns list hotel ids in city 
        public List<string> GetHotelIds(string cityName)
        {
            using (HotelSystemLinqDataContext contex = new HotelSystemLinqDataContext())
            {
                var hotelId = from address
                              in contex.Addresses
                              where address.City.ToLower() == cityName.ToLower()
                              select address.HotelId;
                return hotelId.ToList();
            }
        }
    }
}
