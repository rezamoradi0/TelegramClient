using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1613493288)]
    public class TlNotifyPeer : TlAbsNotifyPeer
    {
        [SerializationOrder(0)]
        public TlAbsPeer Peer { get; set; }
    }
}