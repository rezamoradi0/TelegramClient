using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1443858741)]
    public class TlSentEncryptedMessage : TlAbsSentEncryptedMessage
    {
        [SerializationOrder(0)]
        public int Date { get; set; }
    }
}