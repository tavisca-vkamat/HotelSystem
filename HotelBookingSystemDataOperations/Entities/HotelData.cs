using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystemDataOperations.Entities
{
    public class HotelData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public int MinRate { get; set; }
        public int MaxRate { get; set; }
    }
}
