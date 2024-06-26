﻿using cosmos.ibase.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class WeightedVoteOption : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"option")]
        public VoteOption Option { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"weight")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Weight { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TextProposal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"title")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Title { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"description")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Description { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Deposit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"depositor")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Depositor { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public global::System.Collections.Generic.List<Coin> Amounts { get; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Proposal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"content")]
        public global::Google.Protobuf.WellKnownTypes.Any Content { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"status")]
        public ProposalStatus Status { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"final_tally_result")]
        public TallyResult FinalTallyResult { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"submit_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? SubmitTime { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"deposit_end_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? DepositEndTime { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"total_deposit")]
        public global::System.Collections.Generic.List<Coin> TotalDeposits { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(8, Name = @"voting_start_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? VotingStartTime { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"voting_end_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? VotingEndTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TallyResult : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"yes")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Yes { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"abstain")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Abstain { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"no")]
        [global::System.ComponentModel.DefaultValue("")]
        public string No { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"no_with_veto")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NoWithVeto { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Vote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"option")]
        [global::System.Obsolete]
        public VoteOption Option { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"options")]
        public global::System.Collections.Generic.List<WeightedVoteOption> Options { get; } = new global::System.Collections.Generic.List<WeightedVoteOption>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DepositParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"min_deposit")]
        public global::System.Collections.Generic.List<Coin> MinDeposits { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(2, Name = @"max_deposit_period", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? MaxDepositPeriod { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VotingParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"voting_period", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? VotingPeriod { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TallyParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"quorum")]
        public byte[] Quorum { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"threshold")]
        public byte[] Threshold { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"veto_threshold")]
        public byte[] VetoThreshold { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum VoteOption
    {
        [global::ProtoBuf.ProtoEnum(Name = @"VOTE_OPTION_UNSPECIFIED")]
        VoteOptionUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"VOTE_OPTION_YES")]
        VoteOptionYes = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"VOTE_OPTION_ABSTAIN")]
        VoteOptionAbstain = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"VOTE_OPTION_NO")]
        VoteOptionNo = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"VOTE_OPTION_NO_WITH_VETO")]
        VoteOptionNoWithVeto = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ProposalStatus
    {
        [global::ProtoBuf.ProtoEnum(Name = @"PROPOSAL_STATUS_UNSPECIFIED")]
        ProposalStatusUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"PROPOSAL_STATUS_DEPOSIT_PERIOD")]
        ProposalStatusDepositPeriod = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PROPOSAL_STATUS_VOTING_PERIOD")]
        ProposalStatusVotingPeriod = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"PROPOSAL_STATUS_PASSED")]
        ProposalStatusPassed = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"PROPOSAL_STATUS_REJECTED")]
        ProposalStatusRejected = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"PROPOSAL_STATUS_FAILED")]
        ProposalStatusFailed = 5,
    }
}
