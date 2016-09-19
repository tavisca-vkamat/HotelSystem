﻿using System.Runtime.Serialization;

namespace HotelServiceAPI.Commons.Entities
{
    [DataContract]
    public class HotelFilter
    {
        [DataMember]
        string cityName;
        [DataMember]
        string rating;
        [DataMember]
        string minRate;
        [DataMember]
        string[] amenities;

        public HotelFilter(string cityName, string rating, string minRate, string[] amenities)
        {
            this.cityName = cityName;
            this.rating = rating;
            this.minRate = minRate;
            this.amenities = amenities;
        }

        public HotelFilter()
        {
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public string MinRate
        {
            get
            {
                return minRate;
            }

            set
            {
                minRate = value;
            }
        }

        public string[] Amenities
        {
            get
            {
                return amenities;
            }

            set
            {
                amenities = value;
            }
        }
    }
}