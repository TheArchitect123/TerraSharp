﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace CosmosProto
{

    public static partial class Extensions
    {
        public static string GetInterfaceType(this global::Google.Protobuf.Reflection.MessageOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<string>(obj, 93001);

        public static void SetInterfaceType(this global::Google.Protobuf.Reflection.MessageOptions obj, string value)
            => global::ProtoBuf.Extensible.AppendValue<string>(obj, 93001, value);

        public static string GetImplementsInterface(this global::Google.Protobuf.Reflection.MessageOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<string>(obj, 93002);

        public static void SetImplementsInterface(this global::Google.Protobuf.Reflection.MessageOptions obj, string value)
            => global::ProtoBuf.Extensible.AppendValue<string>(obj, 93002, value);

        public static string GetAcceptsInterface(this global::Google.Protobuf.Reflection.FieldOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<string>(obj, 93001);

        public static void SetAcceptsInterface(this global::Google.Protobuf.Reflection.FieldOptions obj, string value)
            => global::ProtoBuf.Extensible.AppendValue<string>(obj, 93001, value);

    }
}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
