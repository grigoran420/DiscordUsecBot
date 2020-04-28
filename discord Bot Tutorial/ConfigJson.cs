using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace discord_Bot_Tutorial
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token         { get; private set; }

        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
