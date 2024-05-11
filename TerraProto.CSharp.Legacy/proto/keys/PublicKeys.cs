﻿using Newtonsoft.Json;

namespace Terra.Microsoft.ProtoBufs.proto.keys
{
    [ProtoBuf.ProtoContract()]
    public class PublicKeys
    {
        [ProtoBuf.ProtoMember(1, Name = "@type")]
        [JsonProperty("@type")]
        public string Type { get; set; }


        [ProtoBuf.ProtoMember(2, Name = "Key")]
        public string Key { get; set; }
    }
}
