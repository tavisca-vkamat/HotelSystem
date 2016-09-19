using System.Runtime.Serialization;

namespace HotelServiceAPI.Common.Entities
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Locality { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}