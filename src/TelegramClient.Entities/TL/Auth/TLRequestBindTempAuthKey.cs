using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-841733627)]
    public class TlRequestBindTempAuthKey : TlMethod
    {
        [SerializationOrder(0)]
        public long PermAuthKeyId { get; set; }

        [SerializationOrder(1)]
        public long Nonce { get; set; }

        [SerializationOrder(2)]
        public int ExpiresAt { get; set; }

        [SerializationOrder(3)]
        public byte[] EncryptedMessage { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}