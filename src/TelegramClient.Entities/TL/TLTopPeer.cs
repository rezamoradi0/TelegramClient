using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-305282981)]
    public class TlTopPeer : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsPeer Peer { get; set; }

        [SerializationOrder(1)]
        public double Rating { get; set; }
    }
}