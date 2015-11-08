﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EthereumRpc
{
    public class RpcResultBase
    {
        [JsonProperty(PropertyName = "id", Order = 0)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "jsonrpc", Order = 1)]
         public decimal JsonRpc { get; set; }
    }
}