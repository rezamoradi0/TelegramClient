using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1855224129)]
    public class TlUpdateChatAdmins : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public bool Enabled { get; set; }

        [SerializationOrder(2)]
        public int Version { get; set; }
    }
}