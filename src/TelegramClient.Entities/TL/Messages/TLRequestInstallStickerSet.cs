using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-946871200)]
    public class TlRequestInstallStickerSet : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputStickerSet Stickerset { get; set; }

        [SerializationOrder(1)]
        public bool Archived { get; set; }

        public TlAbsStickerSetInstallResult Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsStickerSetInstallResult) ObjectUtils.DeserializeObject(br);
        }
    }
}