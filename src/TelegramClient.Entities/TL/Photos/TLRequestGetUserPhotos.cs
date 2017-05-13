using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1848823128)]
    public class TlRequestGetUserPhotos : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(1)]
        public int Offset { get; set; }

        [SerializationOrder(2)]
        public long MaxId { get; set; }

        [SerializationOrder(3)]
        public int Limit { get; set; }

        public TlAbsPhotos Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsPhotos) ObjectUtils.DeserializeObject(br);
        }
    }
}