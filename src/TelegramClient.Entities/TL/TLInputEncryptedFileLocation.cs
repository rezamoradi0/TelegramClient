using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-182231723)]
    public class TlInputEncryptedFileLocation : TlAbsInputFileLocation
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}