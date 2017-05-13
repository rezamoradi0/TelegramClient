using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1080796745)]
    public class TlRequestInvokeWithoutUpdates : TlMethod
    {
        [SerializationOrder(0)]
        public TlObject Query { get; set; }

        public TlObject Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlObject) ObjectUtils.DeserializeObject(br);
        }
    }
}