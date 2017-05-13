using System.IO;

namespace TelegramClient.Entities.TL.Upload
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-475607115)]
    public class TlRequestGetFile : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputFileLocation Location { get; set; }

        [SerializationOrder(1)]
        public int Offset { get; set; }

        [SerializationOrder(2)]
        public int Limit { get; set; }

        public TlFile Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlFile) ObjectUtils.DeserializeObject(br);
        }
    }
}