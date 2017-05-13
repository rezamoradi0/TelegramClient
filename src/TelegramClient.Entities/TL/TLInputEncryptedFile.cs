using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1511503333)]
    public class TlInputEncryptedFile : TlAbsInputEncryptedFile
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}