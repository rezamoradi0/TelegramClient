using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-162681021)]
    public class TlRequestRequestEncryption : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(1)]
        public int RandomId { get; set; }

        [SerializationOrder(2)]
        public byte[] GA { get; set; }

        public TlAbsEncryptedChat Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsEncryptedChat) ObjectUtils.DeserializeObject(br);
        }
    }
}