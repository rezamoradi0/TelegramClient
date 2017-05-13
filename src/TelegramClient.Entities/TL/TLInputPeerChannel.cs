using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(548253432)]
    public class TlInputPeerChannel : TlAbsInputPeer
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}