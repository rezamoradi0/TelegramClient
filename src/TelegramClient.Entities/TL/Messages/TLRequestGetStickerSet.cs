using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(639215886)]
    public class TlRequestGetStickerSet : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputStickerSet Stickerset { get; set; }

        public TlStickerSet Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlStickerSet) ObjectUtils.DeserializeObject(br);
        }
    }
}