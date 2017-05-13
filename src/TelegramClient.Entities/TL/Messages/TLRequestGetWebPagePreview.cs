using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(623001124)]
    public class TlRequestGetWebPagePreview : TlMethod
    {
        [SerializationOrder(0)]
        public string Message { get; set; }

        public TlAbsMessageMedia Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsMessageMedia) ObjectUtils.DeserializeObject(br);
        }
    }
}