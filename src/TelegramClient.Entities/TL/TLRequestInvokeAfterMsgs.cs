using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1036301552)]
    public class TlRequestInvokeAfterMsgs : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<long> MsgIds { get; set; }

        [SerializationOrder(1)]
        public TlObject Query { get; set; }

        public TlObject Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlObject) ObjectUtils.DeserializeObject(br);
        }
    }
}