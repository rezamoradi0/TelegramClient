using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1035731989)]
    public class TlRequestAcceptEncryption : TlMethod
    {
        [SerializationOrder(0)]
        public TlInputEncryptedChat Peer { get; set; }

        [SerializationOrder(1)]
        public byte[] GB { get; set; }

        [SerializationOrder(2)]
        public long KeyFingerprint { get; set; }

        [SerializationOrder(3)]
        public TlAbsEncryptedChat Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsEncryptedChat) ObjectUtils.DeserializeObject(br);
        }
    }
}