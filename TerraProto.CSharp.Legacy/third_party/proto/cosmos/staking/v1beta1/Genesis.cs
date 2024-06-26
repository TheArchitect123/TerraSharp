﻿namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"last_total_power")]
        public byte[] LastTotalPower { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"last_validator_powers")]
        public global::System.Collections.Generic.List<LastValidatorPower> LastValidatorPowers { get; } = new global::System.Collections.Generic.List<LastValidatorPower>();

        [global::ProtoBuf.ProtoMember(4, Name = @"validators")]
        public global::System.Collections.Generic.List<Validator> Validators { get; } = new global::System.Collections.Generic.List<Validator>();

        [global::ProtoBuf.ProtoMember(5, Name = @"delegations")]
        public global::System.Collections.Generic.List<Delegation> Delegations { get; } = new global::System.Collections.Generic.List<Delegation>();

        [global::ProtoBuf.ProtoMember(6, Name = @"unbonding_delegations")]
        public global::System.Collections.Generic.List<UnbondingDelegation> UnbondingDelegations { get; } = new global::System.Collections.Generic.List<UnbondingDelegation>();

        [global::ProtoBuf.ProtoMember(7, Name = @"redelegations")]
        public global::System.Collections.Generic.List<Redelegation> Redelegations { get; } = new global::System.Collections.Generic.List<Redelegation>();

        [global::ProtoBuf.ProtoMember(8, Name = @"exported")]
        public bool Exported { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LastValidatorPower : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"power")]
        public long Power { get; set; }
    }
}
