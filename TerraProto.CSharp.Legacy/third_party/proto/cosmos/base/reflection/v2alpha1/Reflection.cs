﻿namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.reflection.v2alpha1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class AppDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"authn")]
        public AuthnDescriptor Authn { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"chain")]
        public ChainDescriptor Chain { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"codec")]
        public CodecDescriptor Codec { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"configuration")]
        public ConfigurationDescriptor Configuration { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"query_services")]
        public QueryServicesDescriptor QueryServices { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"tx")]
        public TxDescriptor Tx { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"fullname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Fullname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"msgs")]
        public global::System.Collections.Generic.List<MsgDescriptor> Msgs { get; } = new global::System.Collections.Generic.List<MsgDescriptor>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AuthnDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sign_modes")]
        public global::System.Collections.Generic.List<SigningModeDescriptor> SignModes { get; } = new global::System.Collections.Generic.List<SigningModeDescriptor>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SigningModeDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"number")]
        public int Number { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"authn_info_provider_method_fullname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AuthnInfoProviderMethodFullname { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ChainDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CodecDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"interfaces")]
        public global::System.Collections.Generic.List<InterfaceDescriptor> Interfaces { get; } = new global::System.Collections.Generic.List<InterfaceDescriptor>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class InterfaceDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"fullname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Fullname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"interface_accepting_messages")]
        public global::System.Collections.Generic.List<InterfaceAcceptingMessageDescriptor> InterfaceAcceptingMessages { get; } = new global::System.Collections.Generic.List<InterfaceAcceptingMessageDescriptor>();

        [global::ProtoBuf.ProtoMember(3, Name = @"interface_implementers")]
        public global::System.Collections.Generic.List<InterfaceImplementerDescriptor> InterfaceImplementers { get; } = new global::System.Collections.Generic.List<InterfaceImplementerDescriptor>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class InterfaceImplementerDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"fullname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Fullname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"type_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TypeUrl { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class InterfaceAcceptingMessageDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"fullname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Fullname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"field_descriptor_names")]
        public global::System.Collections.Generic.List<string> FieldDescriptorNames { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConfigurationDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"bech32_account_address_prefix")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Bech32AccountAddressPrefix { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"msg_type_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MsgTypeUrl { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetAuthnDescriptorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetAuthnDescriptorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"authn")]
        public AuthnDescriptor Authn { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetChainDescriptorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetChainDescriptorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"chain")]
        public ChainDescriptor Chain { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetCodecDescriptorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetCodecDescriptorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"codec")]
        public CodecDescriptor Codec { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetConfigurationDescriptorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetConfigurationDescriptorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"config")]
        public ConfigurationDescriptor Config { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetQueryServicesDescriptorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetQueryServicesDescriptorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"queries")]
        public QueryServicesDescriptor Queries { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetTxDescriptorRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetTxDescriptorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        public TxDescriptor Tx { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryServicesDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"query_services")]
        public global::System.Collections.Generic.List<QueryServiceDescriptor> QueryServices { get; } = new global::System.Collections.Generic.List<QueryServiceDescriptor>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryServiceDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"fullname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Fullname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"is_module")]
        public bool IsModule { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"methods")]
        public global::System.Collections.Generic.List<QueryMethodDescriptor> Methods { get; } = new global::System.Collections.Generic.List<QueryMethodDescriptor>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryMethodDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"full_query_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FullQueryPath { get; set; } = "";
    }
}
