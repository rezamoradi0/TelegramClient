using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(872932635)]
    public class TlStickerSetMultiCovered : TlAbsStickerSetCovered
    {
        [SerializationOrder(0)]
        public TlStickerSet Set { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsDocument> Covers { get; set; }
    }
}