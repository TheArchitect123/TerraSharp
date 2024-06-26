﻿using tendermint.types;
using Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.version;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PartSetHeader : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"total")]
        public uint Total { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"hash")]
        public byte[] Hash { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Part : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"index")]
        public uint Index { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"bytes")]
        public byte[] Bytes { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof")]
        public Proof Proof { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BlockID : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hash")]
        public byte[] Hash { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"part_set_header")]
        public PartSetHeader PartSetHeader { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Header : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version")]
        public Consensus Version { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"chain_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChainId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Time { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"last_block_id")]
        public BlockID LastBlockId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"last_commit_hash")]
        public byte[] LastCommitHash { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"data_hash")]
        public byte[] DataHash { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"validators_hash")]
        public byte[] ValidatorsHash { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"next_validators_hash")]
        public byte[] NextValidatorsHash { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"consensus_hash")]
        public byte[] ConsensusHash { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"app_hash")]
        public byte[] AppHash { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"last_results_hash")]
        public byte[] LastResultsHash { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"evidence_hash")]
        public byte[] EvidenceHash { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"proposer_address")]
        public byte[] ProposerAddress { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Data : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"txs")]
        public global::System.Collections.Generic.List<byte[]> Txs { get; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Vote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        public SignedMsgType Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"round")]
        public int Round { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"block_id")]
        public BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"timestamp", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"validator_address")]
        public byte[] ValidatorAddress { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"validator_index")]
        public int ValidatorIndex { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"signature")]
        public byte[] Signature { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Commit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"round")]
        public int Round { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"block_id")]
        public BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"signatures")]
        public global::System.Collections.Generic.List<CommitSig> Signatures { get; } = new global::System.Collections.Generic.List<CommitSig>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CommitSig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_id_flag")]
        public BlockIDFlag BlockIdFlag { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        public byte[] ValidatorAddress { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"timestamp", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"signature")]
        public byte[] Signature { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Proposal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        public SignedMsgType Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"round")]
        public int Round { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"pol_round")]
        public int PolRound { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"block_id")]
        public BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"timestamp", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"signature")]
        public byte[] Signature { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignedHeader : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"header")]
        public Header Header { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"commit")]
        public Commit Commit { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LightBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signed_header")]
        public SignedHeader SignedHeader { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_set")]
        public ValidatorSet ValidatorSet { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BlockMeta : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_id")]
        public BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"block_size")]
        public long BlockSize { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"header")]
        public Header Header { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"num_txs")]
        public long NumTxs { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxProof : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"root_hash")]
        public byte[] RootHash { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof")]
        public Proof Proof { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum BlockIDFlag
    {
        [global::ProtoBuf.ProtoEnum(Name = @"BLOCK_ID_FLAG_UNKNOWN")]
        BlockIdFlagUnknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"BLOCK_ID_FLAG_ABSENT")]
        BlockIdFlagAbsent = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"BLOCK_ID_FLAG_COMMIT")]
        BlockIdFlagCommit = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"BLOCK_ID_FLAG_NIL")]
        BlockIdFlagNil = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum SignedMsgType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SIGNED_MSG_TYPE_UNKNOWN")]
        SignedMsgTypeUnknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGNED_MSG_TYPE_PREVOTE")]
        SignedMsgTypePrevote = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGNED_MSG_TYPE_PRECOMMIT")]
        SignedMsgTypePrecommit = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGNED_MSG_TYPE_PROPOSAL")]
        SignedMsgTypeProposal = 32,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum CheckTxType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"NEW")]
        New = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"RECHECK")]
        Recheck = 1,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EvidenceType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
        Unknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"DUPLICATE_VOTE")]
        DuplicateVote = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"LIGHT_CLIENT_ATTACK")]
        LightClientAttack = 2,
    }
}
