using System.Runtime.Serialization;

namespace HotelServiceAPI.Common.Entities
{
    [DataContract]
    public class Rate
    {
        [DataMember]
        public decimal Minimum { get; set; }
        [DataMember]
        public decimal Maximum { get; set; }
    }
}