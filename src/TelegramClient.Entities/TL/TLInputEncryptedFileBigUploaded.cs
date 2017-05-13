using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(767652808)]
    public class TlInputEncryptedFileBigUploaded : TlAbsInputEncryptedFile
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public int Parts { get; set; }

        [SerializationOrder(2)]
        public int KeyFingerprint { get; set; }
    }
}