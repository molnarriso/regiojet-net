using regiojet_net_api.http;
using regiojet_net_api.types;
using regiojet_net_api.types.api;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace regiojet_net_api.api
{
    public class RoutesAPI
    {
        public static async Task<RoutesSearchSimpleResponse> SearchRoutes(DateTime departureDate,Location departureLocation, Location arrivalLocation,TariffType tariff = TariffType.REGULAR)
        {
            var args = new Dictionary<string, string>
            {
                {"departureDate",$"{departureDate:yyyy-MM-dd}"},
                {"fromLocationId",departureLocation.ID},
                {"fromLocationType",$"{departureLocation.Type}"},
                {"toLocationId",arrivalLocation.ID},
                {"toLocationType",$"{arrivalLocation.Type}"},
            };
            var response = await RegioHttpClient.Get<RoutesSearchSimpleResponse>("routes/search/simple", args);
            return response;
        }  
    }
}
