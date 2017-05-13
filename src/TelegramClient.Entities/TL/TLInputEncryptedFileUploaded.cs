using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1690108678)]
    public class TlInputEncryptedFileUploaded : TlAbsInputEncryptedFile
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public int Parts { get; set; }

        [SerializationOrder(2)]
        public string Md5Checksum { get; set; }

        [SerializationOrder(3)]
        public int KeyFingerprint { get; set; }
    }
}