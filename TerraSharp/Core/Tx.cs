﻿using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Transaction;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Converters;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Client.Core.Extensions;

namespace Terra.Microsoft.Client.Core
{
    //public class TxSignatures
    //{
    //    public string signature { get; set; }
    //    public Any pub_key { get; set; }
    //    public int account_number { get; set; }
    //    public int sequence { get; set; }

    //}
    public class Tx
    {
        public readonly TxBody body;
        public readonly AuthInfo auth_info;
        public List<string> signatures;
        public double accNumber;
        public Tx(
            TxBody body,
            AuthInfo auth_info,
            List<string> signatures,
            double accNumber)
        {
            this.accNumber = accNumber;
            this.body = body;
            this.auth_info = auth_info;
            this.signatures = signatures;
        }

        public static Tx FromData(TxDataArgs data)
        {
            return new Tx(
                TxBody.FromData(data.Body),
                AuthInfo.FromData(data.Auth_info),
                data.Signatures.ToList(), 0);
        }
        public static Tx FromJSON(TxValueJSON data)
        {
            return new Tx(
                TxBody.FromJSON(data.body),
                AuthInfo.FromJSON(data.auth_info),
                null, 0);
        }

        public byte[] ToProto(object[] msgs)
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType(msgs));
        }
        public PROTO.Tx ToProtoWithType(object[] msgs)
        {
            var authType = this.auth_info.ToProtoWithType();

            var csign = new List<PROTO.TxSignatures>()
                {
                    new PROTO.TxSignatures(){
                        Signature = this.signatures[0],
                        AccNumber =this.accNumber,
                        PublicKey = authType.SignerInfos[0].PublicKey,
                        Sequence = authType.SignerInfos[0].Sequence
                    }
                };


            return new PROTO.Tx()
            {
                AuthInfo = authType,
                Body = this.body.ToProtoWithType(msgs.ToList().ConvertAll(w => JSONMessageBodyConverter.GetJsonFromBody(w)).ToArray()),
                Signatures = csign,
            };
        }

        public TxDataArgs ToData()
        {
            return new TxDataArgs()
            {
                Auth_info = this.auth_info.ToData(),
                Body = this.body.ToData(),
                Signatures = this.signatures.ToArray()
            };
        }




        //public Any PackAny()
        //{
        //    return new Any()
        //    {
        //        TypeUrl = TxConstants.STD_TX,
        //        Value = this.ToProto()
        //    };
        //}

        //public Tx AppendEmptySignatures(SignerData[] signers)
        //{
        //    foreach (var signer in signers)
        //    {
        //        SignerInfo signerInfo;
        //        if (signer.PublicKey != null)
        //        {
        //            if (signer.PublicKey.IsMultiSig())
        //            {
        //                signerInfo = new SignerInfo(signer.PublicKey, signer.SequenceNumber.Value,
        //                    new SignatureV2n.ModeInfo(new SignatureV2Multi(CompactBitArray.FromBits((uint)signer.PublicKey.Public_keys.Length),
        //                    new SignatureV2n.SignatureV2Descriptor[] { })));
        //            }
        //            else
        //            {
        //                signerInfo = new SignerInfo(signer.PublicKey, signer.SequenceNumber.Value,
        //                    new SignatureV2n.ModeInfo(new SignatureV2Single(SignMode.SignModeDirect, signer.PublicKey.Key)));
        //            }
        //        }
        //        else
        //        {
        //            signerInfo = new SignerInfo(
        //                new KeysDto() { Key = "" },
        //                signer.SequenceNumber.Value,
        //                new SignatureV2n.ModeInfo(new SignatureV2Single(SignMode.SignModeDirect, "")));
        //        }

        //        this.auth_info?.signer_infos?.Add(signerInfo);
        //    }

        //    return this;
        //}

        private void ClearSignatures()
        {
            this.auth_info?.signer_infos.Clear();
            this.signatures.Clear();
        }

        public void AppendSignatures(SignatureV2[] signatures)
        {
            this.ClearSignatures();
            foreach (var signature in signatures)
            {
                var modes = signature.data.ToModeInfoAndSignature();
                this.signatures.Add(modes.Value);
                this.auth_info?.signer_infos?.Add(new SignerInfo(signature.public_key, signature.sequence, modes.Key));
            }
        }
    }

    public class TxAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public TxAminoValueArgs Value { get; set; }
        public TxAminoArgs()
        {
            this.Type = TxConstants.STD_TX;
        }
    }

    public class TxAminoValueArgs
    {
        public TxBodyJSONMessages[] Msg { get; set; }
        public FeeAminoArgs Fee { get; set; }
        public SignatureV2AminoArgs[] Signatures { get; set; }
        public string Memo { get; set; }
        public string Timeout_Height { get; set; }
    }

    public class TxDataArgs
    {
        public TxBodyDataArgs Body { get; set; }
        public AuthInfoDataArgs Auth_info { get; set; }
        public string[] Signatures { get; set; }
    }
}
