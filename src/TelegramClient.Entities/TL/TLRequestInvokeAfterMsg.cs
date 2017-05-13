using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-878758099)]
    public class TlRequestInvokeAfterMsg : TlMethod
    {
        [SerializationOrder(0)]
        public long MsgId { get; set; }

        [SerializationOrder(1)]
        public TlObject Query { get; set; }

        public TlObject Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlObject) ObjectUtils.DeserializeObject(br);
        }
    }
}