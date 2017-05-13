using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1678812626)]
    public class TlStickerSetCovered : TlAbsStickerSetCovered
    {
        [SerializationOrder(0)]
        public TlStickerSet Set { get; set; }

        [SerializationOrder(1)]
        public TlAbsDocument Cover { get; set; }
    }
}