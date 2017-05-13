using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1649296275)]
    public class TlPeerUser : TlAbsPeer
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }
    }
}