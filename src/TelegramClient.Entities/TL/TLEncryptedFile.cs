using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1248893260)]
    public class TlEncryptedFile : TlAbsEncryptedFile
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }

        [SerializationOrder(2)]
        public int Size { get; set; }

        [SerializationOrder(3)]
        public int DcId { get; set; }

        [SerializationOrder(4)]
        public int KeyFingerprint { get; set; }
    }
}