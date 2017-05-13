using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(956179895)]
    public class TlUpdateEncryptedMessagesRead : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public int MaxDate { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }
    }
}