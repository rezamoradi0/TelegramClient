using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(396093539)]
    public class TlInputPeerChat : TlAbsInputPeer
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }
    }
}