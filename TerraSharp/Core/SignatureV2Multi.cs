﻿using Terra.Microsoft.Rest.Tx.Transaction;
using static Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1.ModeInfo;
using System.Linq;
using Terra.Microsoft.Client.Core.SignatureV2n;

namespace Terra.Microsoft.Client.Core
{
    public class SignatureV2Multi
    {
        public readonly CompactBitArray bitArray;
        public readonly SignatureV2Descriptor[] signatures;
        public SignatureV2Multi(CompactBitArray bitArray, SignatureV2Descriptor[] signatures)
        {
            this.bitArray = bitArray;
            this.signatures = signatures;
        }

        public static SignatureV2Multi FromData(MultiDataArgs data)
        {
            return new SignatureV2Multi(CompactBitArray.FromData(data.BitArray), data.Signatures.ToList().ConvertAll(w => SignatureV2Descriptor.FromData(w)).ToArray());
        }

        public MultiDataArgs ToData()
        {
            return new MultiDataArgs()
            {
                BitArray = this.bitArray.ToData(),
                Signatures = this.signatures.ToList().ConvertAll(w => w.ToData()).ToArray()
            };
        }
        public TxSignerModeInfoMulti ToJSON()
        {
            return new TxSignerModeInfoMulti()
            {
                bitarray = this.bitArray.ToJSON(),
            };
        }
        public Multi ToProtoWithType()
        {
            return new Multi()
            {
                 Bitarray = this.bitArray.ToProtoWithTypeSign(),
            };
        }

    }
    public class MultiDataArgs
    {
        public CompactBitArrayData BitArray { get; set; }
        public SignatureV2DescriptorDataArgs[] Signatures { get; set; }
    }
}
