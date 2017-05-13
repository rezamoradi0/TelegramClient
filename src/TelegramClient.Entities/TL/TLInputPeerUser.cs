using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2072935910)]
    public class TlInputPeerUser : TlAbsInputPeer
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}