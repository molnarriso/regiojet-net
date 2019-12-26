using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace regiojet_net_api.types
{
    public class Route
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("departureStationId")]
        public string DepartureStationId { get; set; }

        [JsonProperty("departureTime")]
        public DateTime DepartureTime { get; set; }

        [JsonProperty("arrivalStationId")]
        public string ArrivalStationId { get; set; }

        [JsonProperty("arrivalTime")]
        public DateTime ArrivalTime { get; set; }

        [JsonProperty("freeSeatsCount")]
        public long FreeSeatsCount { get; set; }

        [JsonProperty("priceFrom")]
        public long PriceFrom { get; set; }

        [JsonProperty("priceTo")]
        public long PriceTo { get; set; }

        [JsonProperty("pricesCount")]
        public long PricesCount { get; set; }

        [JsonProperty("bookable")]
        public bool Bookable { get; set; }

        [JsonProperty("travelTime")]
        public string TravelTime { get; set; }

        [JsonProperty("vehicleStandardKey")]
        public string VehicleStandardKey { get; set; }
    }
}
