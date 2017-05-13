using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(864953444)]
    public class TlRequestGetDocumentByHash : TlMethod
    {
        [SerializationOrder(0)]
        public byte[] Sha256 { get; set; }

        [SerializationOrder(1)]
        public int Size { get; set; }

        [SerializationOrder(2)]
        public string MimeType { get; set; }

        public TlAbsDocument Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsDocument) ObjectUtils.DeserializeObject(br);
        }
    }
}