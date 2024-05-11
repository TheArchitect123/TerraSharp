﻿using cosmos.ibase.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crisis.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(3, Name = @"constant_fee")]
        public Coin ConstantFee { get; set; }
    }
}
