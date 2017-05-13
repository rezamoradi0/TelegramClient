using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(469850889)]
    public class TlRequestDeleteHistory : TlMethod<>
    {
        [SerializationOrder(0)]
        public int Flags { get; set; }

        public bool JustClear
        {
            get => (Flags & 1) != 0;
            set => Flags = value ? 0 | 1 : 0 & ~1;
        }

        [SerializationOrder(1)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(2)]
        public int MaxId { get; set; }
    }
}