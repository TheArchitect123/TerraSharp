﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tendermint.types;
using Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.abci
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"echo")]
        public RequestEcho Echo
        {
            get => __pbn__value.Is(1) ? ((RequestEcho)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(1, value);
        }
        public bool ShouldSerializeEcho() => __pbn__value.Is(1);
        public void ResetEcho() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 1);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__value;

        [global::ProtoBuf.ProtoMember(2, Name = @"flush")]
        public RequestFlush Flush
        {
            get => __pbn__value.Is(2) ? ((RequestFlush)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
        }
        public bool ShouldSerializeFlush() => __pbn__value.Is(2);
        public void ResetFlush() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 2);

        [global::ProtoBuf.ProtoMember(3, Name = @"info")]
        public RequestInfo Info
        {
            get => __pbn__value.Is(3) ? ((RequestInfo)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(3, value);
        }
        public bool ShouldSerializeInfo() => __pbn__value.Is(3);
        public void ResetInfo() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 3);

        [global::ProtoBuf.ProtoMember(4, Name = @"set_option")]
        public RequestSetOption SetOption
        {
            get => __pbn__value.Is(4) ? ((RequestSetOption)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(4, value);
        }
        public bool ShouldSerializeSetOption() => __pbn__value.Is(4);
        public void ResetSetOption() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 4);

        [global::ProtoBuf.ProtoMember(5, Name = @"init_chain")]
        public RequestInitChain InitChain
        {
            get => __pbn__value.Is(5) ? ((RequestInitChain)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(5, value);
        }
        public bool ShouldSerializeInitChain() => __pbn__value.Is(5);
        public void ResetInitChain() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 5);

        [global::ProtoBuf.ProtoMember(6, Name = @"query")]
        public RequestQuery Query
        {
            get => __pbn__value.Is(6) ? ((RequestQuery)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(6, value);
        }
        public bool ShouldSerializeQuery() => __pbn__value.Is(6);
        public void ResetQuery() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 6);

        [global::ProtoBuf.ProtoMember(7, Name = @"begin_block")]
        public RequestBeginBlock BeginBlock
        {
            get => __pbn__value.Is(7) ? ((RequestBeginBlock)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(7, value);
        }
        public bool ShouldSerializeBeginBlock() => __pbn__value.Is(7);
        public void ResetBeginBlock() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 7);

        [global::ProtoBuf.ProtoMember(8, Name = @"check_tx")]
        public RequestCheckTx CheckTx
        {
            get => __pbn__value.Is(8) ? ((RequestCheckTx)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(8, value);
        }
        public bool ShouldSerializeCheckTx() => __pbn__value.Is(8);
        public void ResetCheckTx() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 8);

        [global::ProtoBuf.ProtoMember(9, Name = @"deliver_tx")]
        public RequestDeliverTx DeliverTx
        {
            get => __pbn__value.Is(9) ? ((RequestDeliverTx)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(9, value);
        }
        public bool ShouldSerializeDeliverTx() => __pbn__value.Is(9);
        public void ResetDeliverTx() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 9);

        [global::ProtoBuf.ProtoMember(10, Name = @"end_block")]
        public RequestEndBlock EndBlock
        {
            get => __pbn__value.Is(10) ? ((RequestEndBlock)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(10, value);
        }
        public bool ShouldSerializeEndBlock() => __pbn__value.Is(10);
        public void ResetEndBlock() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 10);

        [global::ProtoBuf.ProtoMember(11, Name = @"commit")]
        public RequestCommit Commit
        {
            get => __pbn__value.Is(11) ? ((RequestCommit)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(11, value);
        }
        public bool ShouldSerializeCommit() => __pbn__value.Is(11);
        public void ResetCommit() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 11);

        [global::ProtoBuf.ProtoMember(12, Name = @"list_snapshots")]
        public RequestListSnapshots ListSnapshots
        {
            get => __pbn__value.Is(12) ? ((RequestListSnapshots)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(12, value);
        }
        public bool ShouldSerializeListSnapshots() => __pbn__value.Is(12);
        public void ResetListSnapshots() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 12);

        [global::ProtoBuf.ProtoMember(13, Name = @"offer_snapshot")]
        public RequestOfferSnapshot OfferSnapshot
        {
            get => __pbn__value.Is(13) ? ((RequestOfferSnapshot)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(13, value);
        }
        public bool ShouldSerializeOfferSnapshot() => __pbn__value.Is(13);
        public void ResetOfferSnapshot() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 13);

        [global::ProtoBuf.ProtoMember(14, Name = @"load_snapshot_chunk")]
        public RequestLoadSnapshotChunk LoadSnapshotChunk
        {
            get => __pbn__value.Is(14) ? ((RequestLoadSnapshotChunk)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(14, value);
        }
        public bool ShouldSerializeLoadSnapshotChunk() => __pbn__value.Is(14);
        public void ResetLoadSnapshotChunk() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 14);

        [global::ProtoBuf.ProtoMember(15, Name = @"apply_snapshot_chunk")]
        public RequestApplySnapshotChunk ApplySnapshotChunk
        {
            get => __pbn__value.Is(15) ? ((RequestApplySnapshotChunk)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(15, value);
        }
        public bool ShouldSerializeApplySnapshotChunk() => __pbn__value.Is(15);
        public void ResetApplySnapshotChunk() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 15);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestEcho : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Message { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestFlush : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"block_version")]
        public ulong BlockVersion { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"p2p_version")]
        public ulong P2pVersion { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestSetOption : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Key { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Value { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestInitChain : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Time { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"chain_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChainId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"consensus_params")]
        public ConsensusParams ConsensusParams { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"validators")]
        public global::System.Collections.Generic.List<ValidatorUpdate> Validators { get; } = new global::System.Collections.Generic.List<ValidatorUpdate>();

        [global::ProtoBuf.ProtoMember(5, Name = @"app_state_bytes")]
        public byte[] AppStateBytes { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"initial_height")]
        public long InitialHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestQuery : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Path { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"prove")]
        public bool Prove { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestBeginBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hash")]
        public byte[] Hash { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"header")]
        public Header Header { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"last_commit_info")]
        public LastCommitInfo LastCommitInfo { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"byzantine_validators")]
        public global::System.Collections.Generic.List<Evidence> ByzantineValidators { get; } = new global::System.Collections.Generic.List<Evidence>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestCheckTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        public byte[] Tx { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"type")]
        public CheckTxType Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestDeliverTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        public byte[] Tx { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestEndBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestCommit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestListSnapshots : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestOfferSnapshot : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"snapshot")]
        public Snapshot Snapshot { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"app_hash")]
        public byte[] AppHash { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestLoadSnapshotChunk : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public ulong Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"format")]
        public uint Format { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"chunk")]
        public uint Chunk { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RequestApplySnapshotChunk : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"index")]
        public uint Index { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"chunk")]
        public byte[] Chunk { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"exception")]
        public ResponseException Exception
        {
            get => __pbn__value.Is(1) ? ((ResponseException)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(1, value);
        }
        public bool ShouldSerializeException() => __pbn__value.Is(1);
        public void ResetException() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 1);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__value;

        [global::ProtoBuf.ProtoMember(2, Name = @"echo")]
        public ResponseEcho Echo
        {
            get => __pbn__value.Is(2) ? ((ResponseEcho)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
        }
        public bool ShouldSerializeEcho() => __pbn__value.Is(2);
        public void ResetEcho() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 2);

        [global::ProtoBuf.ProtoMember(3, Name = @"flush")]
        public ResponseFlush Flush
        {
            get => __pbn__value.Is(3) ? ((ResponseFlush)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(3, value);
        }
        public bool ShouldSerializeFlush() => __pbn__value.Is(3);
        public void ResetFlush() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 3);

        [global::ProtoBuf.ProtoMember(4, Name = @"info")]
        public ResponseInfo Info
        {
            get => __pbn__value.Is(4) ? ((ResponseInfo)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(4, value);
        }
        public bool ShouldSerializeInfo() => __pbn__value.Is(4);
        public void ResetInfo() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 4);

        [global::ProtoBuf.ProtoMember(5, Name = @"set_option")]
        public ResponseSetOption SetOption
        {
            get => __pbn__value.Is(5) ? ((ResponseSetOption)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(5, value);
        }
        public bool ShouldSerializeSetOption() => __pbn__value.Is(5);
        public void ResetSetOption() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 5);

        [global::ProtoBuf.ProtoMember(6, Name = @"init_chain")]
        public ResponseInitChain InitChain
        {
            get => __pbn__value.Is(6) ? ((ResponseInitChain)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(6, value);
        }
        public bool ShouldSerializeInitChain() => __pbn__value.Is(6);
        public void ResetInitChain() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 6);

        [global::ProtoBuf.ProtoMember(7, Name = @"query")]
        public ResponseQuery Query
        {
            get => __pbn__value.Is(7) ? ((ResponseQuery)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(7, value);
        }
        public bool ShouldSerializeQuery() => __pbn__value.Is(7);
        public void ResetQuery() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 7);

        [global::ProtoBuf.ProtoMember(8, Name = @"begin_block")]
        public ResponseBeginBlock BeginBlock
        {
            get => __pbn__value.Is(8) ? ((ResponseBeginBlock)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(8, value);
        }
        public bool ShouldSerializeBeginBlock() => __pbn__value.Is(8);
        public void ResetBeginBlock() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 8);

        [global::ProtoBuf.ProtoMember(9, Name = @"check_tx")]
        public ResponseCheckTx CheckTx
        {
            get => __pbn__value.Is(9) ? ((ResponseCheckTx)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(9, value);
        }
        public bool ShouldSerializeCheckTx() => __pbn__value.Is(9);
        public void ResetCheckTx() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 9);

        [global::ProtoBuf.ProtoMember(10, Name = @"deliver_tx")]
        public ResponseDeliverTx DeliverTx
        {
            get => __pbn__value.Is(10) ? ((ResponseDeliverTx)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(10, value);
        }
        public bool ShouldSerializeDeliverTx() => __pbn__value.Is(10);
        public void ResetDeliverTx() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 10);

        [global::ProtoBuf.ProtoMember(11, Name = @"end_block")]
        public ResponseEndBlock EndBlock
        {
            get => __pbn__value.Is(11) ? ((ResponseEndBlock)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(11, value);
        }
        public bool ShouldSerializeEndBlock() => __pbn__value.Is(11);
        public void ResetEndBlock() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 11);

        [global::ProtoBuf.ProtoMember(12, Name = @"commit")]
        public ResponseCommit Commit
        {
            get => __pbn__value.Is(12) ? ((ResponseCommit)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(12, value);
        }
        public bool ShouldSerializeCommit() => __pbn__value.Is(12);
        public void ResetCommit() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 12);

        [global::ProtoBuf.ProtoMember(13, Name = @"list_snapshots")]
        public ResponseListSnapshots ListSnapshots
        {
            get => __pbn__value.Is(13) ? ((ResponseListSnapshots)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(13, value);
        }
        public bool ShouldSerializeListSnapshots() => __pbn__value.Is(13);
        public void ResetListSnapshots() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 13);

        [global::ProtoBuf.ProtoMember(14, Name = @"offer_snapshot")]
        public ResponseOfferSnapshot OfferSnapshot
        {
            get => __pbn__value.Is(14) ? ((ResponseOfferSnapshot)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(14, value);
        }
        public bool ShouldSerializeOfferSnapshot() => __pbn__value.Is(14);
        public void ResetOfferSnapshot() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 14);

        [global::ProtoBuf.ProtoMember(15, Name = @"load_snapshot_chunk")]
        public ResponseLoadSnapshotChunk LoadSnapshotChunk
        {
            get => __pbn__value.Is(15) ? ((ResponseLoadSnapshotChunk)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(15, value);
        }
        public bool ShouldSerializeLoadSnapshotChunk() => __pbn__value.Is(15);
        public void ResetLoadSnapshotChunk() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 15);

        [global::ProtoBuf.ProtoMember(16, Name = @"apply_snapshot_chunk")]
        public ResponseApplySnapshotChunk ApplySnapshotChunk
        {
            get => __pbn__value.Is(16) ? ((ResponseApplySnapshotChunk)__pbn__value.Object) : default;
            set => __pbn__value = new global::ProtoBuf.DiscriminatedUnionObject(16, value);
        }
        public bool ShouldSerializeApplySnapshotChunk() => __pbn__value.Is(16);
        public void ResetApplySnapshotChunk() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__value, 16);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseException : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"error")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Error { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseEcho : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Message { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseFlush : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Data { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"app_version")]
        public ulong AppVersion { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"last_block_height")]
        public long LastBlockHeight { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"last_block_app_hash")]
        public byte[] LastBlockAppHash { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseSetOption : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        public uint Code { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Log { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"info")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Info { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseInitChain : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"consensus_params")]
        public ConsensusParams ConsensusParams { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validators")]
        public global::System.Collections.Generic.List<ValidatorUpdate> Validators { get; } = new global::System.Collections.Generic.List<ValidatorUpdate>();

        [global::ProtoBuf.ProtoMember(3, Name = @"app_hash")]
        public byte[] AppHash { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseQuery : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        public uint Code { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Log { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"info")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Info { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"index")]
        public long Index { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"value")]
        public byte[] Value { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"proof_ops")]
        public ProofOps ProofOps { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"codespace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Codespace { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseBeginBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"events")]
        public global::System.Collections.Generic.List<Event> Events { get; } = new global::System.Collections.Generic.List<Event>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseCheckTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        public uint Code { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Log { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"info")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Info { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"gas_wanted")]
        public long GasWanted { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"gas_used")]
        public long GasUsed { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"events")]
        public global::System.Collections.Generic.List<Event> Events { get; } = new global::System.Collections.Generic.List<Event>();

        [global::ProtoBuf.ProtoMember(8, Name = @"codespace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Codespace { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseDeliverTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        public uint Code { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Log { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"info")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Info { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"gas_wanted")]
        public long GasWanted { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"gas_used")]
        public long GasUsed { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"events")]
        public global::System.Collections.Generic.List<Event> Events { get; } = new global::System.Collections.Generic.List<Event>();

        [global::ProtoBuf.ProtoMember(8, Name = @"codespace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Codespace { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseEndBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_updates")]
        public global::System.Collections.Generic.List<ValidatorUpdate> ValidatorUpdates { get; } = new global::System.Collections.Generic.List<ValidatorUpdate>();

        [global::ProtoBuf.ProtoMember(2, Name = @"consensus_param_updates")]
        public ConsensusParams ConsensusParamUpdates { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"events")]
        public global::System.Collections.Generic.List<Event> Events { get; } = new global::System.Collections.Generic.List<Event>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseCommit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"retain_height")]
        public long RetainHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseListSnapshots : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"snapshots")]
        public global::System.Collections.Generic.List<Snapshot> Snapshots { get; } = new global::System.Collections.Generic.List<Snapshot>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseOfferSnapshot : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public Result result { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public enum Result
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"ACCEPT")]
            Accept = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"ABORT")]
            Abort = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"REJECT")]
            Reject = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"REJECT_FORMAT")]
            RejectFormat = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"REJECT_SENDER")]
            RejectSender = 5,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseLoadSnapshotChunk : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"chunk")]
        public byte[] Chunk { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ResponseApplySnapshotChunk : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public Result result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"refetch_chunks", IsPacked = true)]
        public uint[] RefetchChunks { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"reject_senders")]
        public global::System.Collections.Generic.List<string> RejectSenders { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoContract()]
        public enum Result
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"ACCEPT")]
            Accept = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"ABORT")]
            Abort = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"RETRY")]
            Retry = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"RETRY_SNAPSHOT")]
            RetrySnapshot = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"REJECT_SNAPSHOT")]
            RejectSnapshot = 5,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConsensusParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block")]
        public BlockParams Block { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"evidence")]
        public EvidenceParams Evidence { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"validator")]
        public ValidatorParams Validator { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"version")]
        public VersionParams Version { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BlockParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_bytes")]
        public long MaxBytes { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"max_gas")]
        public long MaxGas { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LastCommitInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"round")]
        public int Round { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"votes")]
        public global::System.Collections.Generic.List<VoteInfo> Votes { get; } = new global::System.Collections.Generic.List<VoteInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Event : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Type { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"attributes")]
        public global::System.Collections.Generic.List<EventAttribute> Attributes { get; } = new global::System.Collections.Generic.List<EventAttribute>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EventAttribute : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        public byte[] Value { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"index")]
        public bool Index { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxResult : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"index")]
        public uint Index { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"tx")]
        public byte[] Tx { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"result")]
        public ResponseDeliverTx Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Validator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        public byte[] Address { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"power")]
        public long Power { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorUpdate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pub_key")]
        public PublicKey PubKey { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"power")]
        public long Power { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VoteInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator")]
        public Validator Validator { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"signed_last_block")]
        public bool SignedLastBlock { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Evidence : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        public EvidenceType Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validator")]
        public Validator Validator { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Time { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"total_voting_power")]
        public long TotalVotingPower { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Snapshot : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public ulong Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"format")]
        public uint Format { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"chunks")]
        public uint Chunks { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"hash")]
        public byte[] Hash { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"metadata")]
        public byte[] Metadata { get; set; }

    }

    public partial interface IABCIApplication
    {
        global::System.Threading.Tasks.ValueTask<ResponseEcho> EchoAsync(RequestEcho value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseFlush> FlushAsync(RequestFlush value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseInfo> InfoAsync(RequestInfo value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseSetOption> SetOptionAsync(RequestSetOption value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseDeliverTx> DeliverTxAsync(RequestDeliverTx value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseCheckTx> CheckTxAsync(RequestCheckTx value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseQuery> QueryAsync(RequestQuery value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseCommit> CommitAsync(RequestCommit value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseInitChain> InitChainAsync(RequestInitChain value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseBeginBlock> BeginBlockAsync(RequestBeginBlock value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseEndBlock> EndBlockAsync(RequestEndBlock value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseListSnapshots> ListSnapshotsAsync(RequestListSnapshots value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseOfferSnapshot> OfferSnapshotAsync(RequestOfferSnapshot value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseLoadSnapshotChunk> LoadSnapshotChunkAsync(RequestLoadSnapshotChunk value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ResponseApplySnapshotChunk> ApplySnapshotChunkAsync(RequestApplySnapshotChunk value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
