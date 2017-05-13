using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1802240206)]
    public class TlSentEncryptedFile : TlAbsSentEncryptedMessage
    {
        [SerializationOrder(0)]
        public int Date { get; set; }

        [SerializationOrder(1)]
        public TlAbsEncryptedFile File { get; set; }
    
    }
}