using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1195615476)]
    public class TlInputNotifyPeer : TlAbsInputNotifyPeer
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }
    }
}