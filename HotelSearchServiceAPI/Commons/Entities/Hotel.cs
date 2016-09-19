using System.Runtime.Serialization;

namespace HotelServiceAPI.Common.Entities
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public float Rating { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public Address Address { get; set; }
        [DataMember]
        public Rate Rate { get; set; }
    }
}