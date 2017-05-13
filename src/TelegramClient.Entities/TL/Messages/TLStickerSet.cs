using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1240849242)]
    public class TlStickerSet : TlObject
    {
        [SerializationOrder(0)]
        public TlStickerSet Set { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlStickerPack> Packs { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsDocument> Documents { get; set; }

    }
}