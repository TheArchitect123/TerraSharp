﻿
namespace Terra.Microsoft.Rest.Tx.Block
{
    public class CreateTxOptions
    {
        public double? gas { get; set; }
        public double? gasAdjustment { get; set; }
        public string feeDenom { get; set; }
        public double? timeoutHeight { get; set; }
        public string FeeGranter { get; set; }
    }
}
