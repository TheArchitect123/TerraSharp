﻿namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.auth.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class BaseAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pub_key")]
        public global::Google.Protobuf.WellKnownTypes.Any PubKey { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"account_number")]
        public ulong AccountNumber { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"sequence")]
        public ulong Sequence { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModuleAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_account")]
        public BaseAccount BaseAccount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"permissions")]
        public global::System.Collections.Generic.List<string> Permissions { get; } = new global::System.Collections.Generic.List<string>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_memo_characters")]
        public ulong MaxMemoCharacters { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_sig_limit")]
        public ulong TxSigLimit { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"tx_size_cost_per_byte")]
        public ulong TxSizeCostPerByte { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"sig_verify_cost_ed25519")]
        public ulong SigVerifyCostEd25519 { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"sig_verify_cost_secp256k1")]
        public ulong SigVerifyCostSecp256k1 { get; set; }
    }
}
