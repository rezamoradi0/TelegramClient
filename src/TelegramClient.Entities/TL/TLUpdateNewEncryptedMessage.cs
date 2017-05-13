using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(314359194)]
    public class TlUpdateNewEncryptedMessage : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsEncryptedMessage Message { get; set; }

        [SerializationOrder(1)]
        public int Qts { get; set; }
    }
}