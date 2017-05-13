using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-841733627)]
    public class TlRequestBindTempAuthKey : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public long PermAuthKeyId { get; set; }

        [SerializationOrder(1)]
        public long Nonce { get; set; }

        [SerializationOrder(2)]
        public int ExpiresAt { get; set; }

        [SerializationOrder(3)]
        public byte[] EncryptedMessage { get; set; }
    }
}