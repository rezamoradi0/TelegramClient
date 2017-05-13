using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1753886890)]
    public class TlUpdateNewStickerSet : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlStickerSet Stickerset { get; set; }
    }
}