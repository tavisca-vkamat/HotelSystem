using HotelServiceAPI.Common.Entities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelServiceAPI
{
    [DataContract]
    public class HotelResponse
    {
        [DataMember]
        public List<Hotel> Hotels { get; set; }
        [DataMember]
        public HotelStatus HotelStatus { get; set; }
    }
}