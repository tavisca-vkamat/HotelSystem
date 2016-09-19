using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelServiceAPI
{
    [DataContract]
    public class HotelStatus
    {
        [DataMember]
        public List<string> Errors { get; set; }
        [DataMember]
        public bool IsFailed { get; set; }
    }
}