using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(386986326)]
    public class TlUpdateEncryptedChatTyping : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }
    }
}