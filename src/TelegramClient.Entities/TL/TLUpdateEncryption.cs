using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1264392051)]
    public class TlUpdateEncryption : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsEncryptedChat Chat { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }
    }
}