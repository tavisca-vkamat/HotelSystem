using HotelBookingSystemDataOperations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystemDataOperations
{
    public class RoomOperations
    {
        public Dictionary<string, Rate> GetRates(List<string> hotelIds)
        {
            Dictionary<string, Rate> rates = new Dictionary<string, Rate>();

            foreach (string hotelid in hotelIds)
            {
                using (HotelSystemLinqDataContext contex = new HotelSystemLinqDataContext())
                {
                    Rate rate = new Rate();
                    rate.Maximum = (from room
                                    in contex.Rooms
                                    where room.HotelId == hotelid
                                    select room.Rate).Max();

                    rate.Minimum = (from room
                                    in contex.Rooms
                                    where room.HotelId == hotelid
                                    select room.Rate).Min();
                    rates.Add(hotelid, rate);
                }
            }
            return rates;
        }
    }
}
