using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(766298703)]
    public class TlRequestGetFeaturedStickers : TlMethod
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        public TlAbsFeaturedStickers Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsFeaturedStickers) ObjectUtils.DeserializeObject(br);
        }
    }
}