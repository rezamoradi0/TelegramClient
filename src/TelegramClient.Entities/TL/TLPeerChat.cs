using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1160714821)]
    public class TlPeerChat : TlAbsPeer
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }
    }
}