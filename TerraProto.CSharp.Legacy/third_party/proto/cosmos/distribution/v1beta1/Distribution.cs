﻿using cosmos.ibase.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.distribution.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"community_tax")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CommunityTax { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"base_proposer_reward")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BaseProposerReward { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"bonus_proposer_reward")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BonusProposerReward { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"withdraw_addr_enabled")]
        public bool WithdrawAddrEnabled { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorHistoricalRewards : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"cumulative_reward_ratio")]
        public global::System.Collections.Generic.List<DecCoin> CumulativeRewardRatioes { get; } = new global::System.Collections.Generic.List<DecCoin>();

        [global::ProtoBuf.ProtoMember(2, Name = @"reference_count")]
        public uint ReferenceCount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorCurrentRewards : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"rewards")]
        public global::System.Collections.Generic.List<DecCoin> Rewards { get; } = new global::System.Collections.Generic.List<DecCoin>();

        [global::ProtoBuf.ProtoMember(2, Name = @"period")]
        public ulong Period { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorAccumulatedCommission : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"commission")]
        public global::System.Collections.Generic.List<DecCoin> Commissions { get; } = new global::System.Collections.Generic.List<DecCoin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorOutstandingRewards : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"rewards")]
        public global::System.Collections.Generic.List<DecCoin> Rewards { get; } = new global::System.Collections.Generic.List<DecCoin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorSlashEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_period")]
        public ulong ValidatorPeriod { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"fraction")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Fraction { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorSlashEvents : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ValidatorSlashEvent> validator_slash_events { get; } = new global::System.Collections.Generic.List<ValidatorSlashEvent>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FeePool : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"community_pool")]
        public global::System.Collections.Generic.List<DecCoin> CommunityPools { get; } = new global::System.Collections.Generic.List<DecCoin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CommunityPoolSpendProposal : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"recipient")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Recipient { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"amount")]
        public global::System.Collections.Generic.List<Coin> Amounts { get; set; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DelegatorStartingInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"previous_period")]
        public ulong PreviousPeriod { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"stake")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Stake { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public ulong Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DelegationDelegatorReward : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"reward")]
        public global::System.Collections.Generic.List<DecCoin> Rewards { get; } = new global::System.Collections.Generic.List<DecCoin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CommunityPoolSpendProposalWithDeposit : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"recipient")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Recipient { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"amount")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Amount { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"deposit")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Deposit { get; set; } = "";

    }

}
