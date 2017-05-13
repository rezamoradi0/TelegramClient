using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-317144808)]
    public class TlEncryptedMessage : TlAbsEncryptedMessage
    {
        [SerializationOrder(0)]
        public long RandomId { get; set; }

        [SerializationOrder(1)]
        public int ChatId { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }

        [SerializationOrder(3)]
        public byte[] Bytes { get; set; }

        [SerializationOrder(4)]
        public TlAbsEncryptedFile File { get; set; }
    }
}