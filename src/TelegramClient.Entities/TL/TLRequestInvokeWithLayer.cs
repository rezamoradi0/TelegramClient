using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-627372787)]
    public class TlRequestInvokeWithLayer : TlMethod
    {
        [SerializationOrder(0)]
        public int Layer { get; set; }

        [SerializationOrder(1)]
        public TlObject Query { get; set; }

        public TlObject Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlObject) ObjectUtils.DeserializeObject(br);
        }
    }
}