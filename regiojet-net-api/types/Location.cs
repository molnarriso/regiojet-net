using System;
using System.Collections.Generic;
using System.Text;

namespace regiojet_net_api.types
{
    public class Location
    {
        public LocationEnum Type;
        public string ID;
        public Location(LocationEnum type, string id) {
            Type = type;
            ID = id;
        }
    }
    public enum LocationEnum
    {
        CITY,STATION
    }
}
