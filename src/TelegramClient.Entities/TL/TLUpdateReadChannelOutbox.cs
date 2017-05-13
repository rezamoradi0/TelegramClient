using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(634833351)]
    public class TlUpdateReadChannelOutbox : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }

        [SerializationOrder(1)]
        public int MaxId { get; set; }
    }
}