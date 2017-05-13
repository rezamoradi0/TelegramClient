using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1701831834)]
    public class TlRequestSendEncryptedFile : TlMethod
    {
        [SerializationOrder(0)]
        public TlInputEncryptedChat Peer { get; set; }

        [SerializationOrder(1)]
        public long RandomId { get; set; }

        [SerializationOrder(2)]
        public byte[] Data { get; set; }

        [SerializationOrder(3)]
        public TlAbsInputEncryptedFile File { get; set; }

        public TlAbsSentEncryptedMessage Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsSentEncryptedMessage) ObjectUtils.DeserializeObject(br);
        }
    }
}