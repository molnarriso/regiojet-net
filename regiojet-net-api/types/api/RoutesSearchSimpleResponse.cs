using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace regiojet_net_api.types.api
{
    public class RoutesSearchSimpleResponse
    {
        [JsonProperty("routes")]
        public Route[] Routes { get; set; }
    }
}
