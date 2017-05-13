using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-110209570)]
    public class TlRequestUninstallStickerSet : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlAbsInputStickerSet Stickerset { get; set; }
    }
}