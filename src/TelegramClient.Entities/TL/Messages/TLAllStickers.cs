using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-302170017)]
    public class TlAllStickers : TlAbsAllStickers
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlStickerSet> Sets { get; set; }
    }
}