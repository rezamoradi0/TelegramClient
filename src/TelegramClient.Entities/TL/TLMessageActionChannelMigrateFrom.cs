using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1336546578)]
    public class TlMessageActionChannelMigrateFrom : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public string Title { get; set; }

        [SerializationOrder(1)]
        public int ChatId { get; set; }
    }
}