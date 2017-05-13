using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-110209570)]
    public class TlRequestUninstallStickerSet : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputStickerSet Stickerset { get; set; }

        [SerializationOrder(1)]
        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}