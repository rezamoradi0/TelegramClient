using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1738988427)]
    public class TlUpdateChannelPinnedMessage : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }

        [SerializationOrder(1)]
        public int Id { get; set; }
    }
}