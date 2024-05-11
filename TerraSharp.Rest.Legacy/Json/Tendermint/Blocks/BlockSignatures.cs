﻿using Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types;

namespace Terra.Microsoft.Rest.Tendermint.Blocks
{
    public class BlockSignatures
    {
        public string block_id_flag { get; set; }
        public string validator_address { get; set; }
        public string timestamp { get; set; }
        public string signature { get; set; }
    }
}
