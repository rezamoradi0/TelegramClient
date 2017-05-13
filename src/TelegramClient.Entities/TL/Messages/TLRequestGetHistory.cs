using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1347868602)]
    public class TlRequestGetHistory : TlMethod<TlAbsMessages>
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public int OffsetId { get; set; }

        [SerializationOrder(2)]
        public int OffsetDate { get; set; }

        [SerializationOrder(3)]
        public int AddOffset { get; set; }

        [SerializationOrder(4)]
        public int Limit { get; set; }

        [SerializationOrder(5)]
        public int MaxId { get; set; }

        [SerializationOrder(6)]
        public int MinId { get; set; }
    }
}