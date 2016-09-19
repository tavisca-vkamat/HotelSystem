using HotelServiceAPI.Common.Entities;
using HotelServiceAPI.Commons.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace HotelServiceAPI.Model.Interfaces
{
    [ServiceContract]
    public interface IHotelFilter
    {
        [OperationContract]
        List<Hotel> Filter(List<Hotel> hotels,HotelFilter filter);
    }
}
