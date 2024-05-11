﻿using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1;

namespace Terra.Microsoft.Rest.Gov.Proposals
{
    public class VotesJSON
    {
        public int proposal_id { get; set; }
        public string voter { get; set; }
        public VoteOption option { get; set; }
        public VoteOptionJSON[] options { get; set; }
    }
}
