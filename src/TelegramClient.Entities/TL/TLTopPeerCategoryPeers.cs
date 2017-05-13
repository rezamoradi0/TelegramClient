using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-75283823)]
    public class TlTopPeerCategoryPeers : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsTopPeerCategory Category { get; set; }

        [SerializationOrder(1)]
        public int Count { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlTopPeer> Peers { get; set; }
    }
}