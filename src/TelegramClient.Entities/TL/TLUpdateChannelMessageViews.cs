using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1734268085)]
    public class TlUpdateChannelMessageViews : TlAbsUpdate
    {
        public int ChannelId { get; set; }

        [SerializationOrder(1)]
        public int Id { get; set; }

        [SerializationOrder(2)]
        public int Views { get; set; }
    }
}