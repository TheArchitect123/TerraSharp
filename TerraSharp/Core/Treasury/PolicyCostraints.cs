﻿using Terra.Microsoft.Extensions.ProtoBufs;
using PROTO = Terra.Microsoft.ProtoBufs.proto.treasury.v1beta1;

namespace Terra.Microsoft.Client.Core.Treasury
{
    public class PolicyConstraints
    {
        public readonly decimal rate_min;
        public readonly decimal rate_max;
        public readonly Coin cap;
        public readonly decimal change_rate_max;

        public PolicyConstraints(
            decimal rate_min,
            decimal rate_max,
            Coin cap,
            decimal change_rate_max)
        {
            this.rate_min = rate_min;
            this.rate_max = rate_max;
            this.cap = cap;
            this.change_rate_max = change_rate_max;
        }

        public static PolicyConstraints FromAmino(PolicyConstraintsAminoArgs data)
        {
            return new PolicyConstraints(
               decimal.Parse(data.Rate_Min),
               decimal.Parse(data.Rate_Max),
               Coin.FromAmino(data.Cap),
               decimal.Parse(data.Change_Rate_Max));
        }

        public static PolicyConstraints FromData(PolicyConstraintsDataArgs data)
        {
            return new PolicyConstraints(
               decimal.Parse(data.Rate_Min),
               decimal.Parse(data.Rate_Max),
               Coin.FromData(data.Cap),
               decimal.Parse(data.Change_Rate_Max));
        }

        public static PolicyConstraints FromProto(PROTO.PolicyConstraints data)
        {
            return new PolicyConstraints(
                decimal.Parse(data.RateMin),
                decimal.Parse(data.RateMax),
                Coin.FromProto(data.Cap),
                decimal.Parse(data.ChangeRateMax));
        }

        public PolicyConstraintsAminoArgs ToAmino()
        {
            return new PolicyConstraintsAminoArgs()
            {
                Rate_Min = this.rate_min.ToString(),
                Rate_Max = this.rate_max.ToString(),
                Cap = this.cap.ToAmino(),
                Change_Rate_Max = this.change_rate_max.ToString()
            };
        }

        public PolicyConstraintsDataArgs ToData()
        {
            return new PolicyConstraintsDataArgs()
            {
                Rate_Min = this.rate_min.ToString(),
                Rate_Max = this.rate_max.ToString(),
                Cap = this.cap.ToData(),
                Change_Rate_Max = this.change_rate_max.ToString()
            };
        }

        public PROTO.PolicyConstraints ToProtoWithType()
        {
            return new PROTO.PolicyConstraints()
            {
                Cap = this.cap.ToProtoWithType(),
                ChangeRateMax = this.change_rate_max.ToString(),
                RateMax = this.rate_max.ToString(),
                RateMin = this.rate_min.ToString(),
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class PolicyConstraintsAminoArgs : PolicyConstraintsCommonArgs
    {
        public CoinAminoArgs Cap { get; set; }
    }

    public class PolicyConstraintsDataArgs : PolicyConstraintsCommonArgs
    {
        public CoinDataArgs Cap { get; set; }
    }

    public class PolicyConstraintsCommonArgs
    {
        public string Rate_Min { get; set; }
        public string Rate_Max { get; set; }
        public string Change_Rate_Max { get; set; }
    }
}
