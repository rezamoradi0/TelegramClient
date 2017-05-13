using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1706608543)]
    public class TlRequestGetMaskStickers : TlMethod
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        public TlAbsAllStickers Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsAllStickers) ObjectUtils.DeserializeObject(br);
        }
    }
}