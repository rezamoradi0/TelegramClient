using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(852769188)]
    public class TlRequestSendEncryptedService : TlMethod
    {
        [SerializationOrder(0)]
        public TlInputEncryptedChat Peer { get; set; }

        [SerializationOrder(1)]
        public long RandomId { get; set; }

        [SerializationOrder(2)]
        public byte[] Data { get; set; }

        public TlAbsSentEncryptedMessage Response { get; set; }
public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsSentEncryptedMessage) ObjectUtils.DeserializeObject(br);
        }
    }
}