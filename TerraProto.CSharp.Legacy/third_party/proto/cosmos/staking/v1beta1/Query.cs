﻿using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.query.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"status")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Status { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validators")]
        public global::System.Collections.Generic.List<Validator> Validators { get; } = new global::System.Collections.Generic.List<Validator>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator")]
        public Validator Validator { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorDelegationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorDelegationsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegation_responses")]
        public global::System.Collections.Generic.List<DelegationResponse> DelegationResponses { get; } = new global::System.Collections.Generic.List<DelegationResponse>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorUnbondingDelegationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryValidatorUnbondingDelegationsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"unbonding_responses")]
        public global::System.Collections.Generic.List<UnbondingDelegation> UnbondingResponses { get; } = new global::System.Collections.Generic.List<UnbondingDelegation>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegationResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegation_response")]
        public DelegationResponse DelegationResponse { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUnbondingDelegationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUnbondingDelegationResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"unbond")]
        public UnbondingDelegation Unbond { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorDelegationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorDelegationsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegation_responses")]
        public global::System.Collections.Generic.List<DelegationResponse> DelegationResponses { get; } = new global::System.Collections.Generic.List<DelegationResponse>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorUnbondingDelegationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorUnbondingDelegationsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"unbonding_responses")]
        public global::System.Collections.Generic.List<UnbondingDelegation> UnbondingResponses { get; } = new global::System.Collections.Generic.List<UnbondingDelegation>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryRedelegationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"src_validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SrcValidatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"dst_validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DstValidatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryRedelegationsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"redelegation_responses")]
        public global::System.Collections.Generic.List<RedelegationResponse> RedelegationResponses { get; } = new global::System.Collections.Generic.List<RedelegationResponse>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorValidatorsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorValidatorsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validators")]
        public global::System.Collections.Generic.List<Validator> Validators { get; } = new global::System.Collections.Generic.List<Validator>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorValidatorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDelegatorValidatorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator")]
        public Validator Validator { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryHistoricalInfoRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryHistoricalInfoResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hist")]
        public HistoricalInfo Hist { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPoolRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPoolResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pool")]
        public Pool Pool { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

    }
}
