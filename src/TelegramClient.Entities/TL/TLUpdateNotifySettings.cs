using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1094555409)]
    public class TlUpdateNotifySettings : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsNotifyPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlAbsPeerNotifySettings NotifySettings { get; set; }
    }
}