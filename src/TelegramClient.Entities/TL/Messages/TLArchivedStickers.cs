using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1338747336)]
    public class TlArchivedStickers : TlObject
    {
        [SerializationOrder(0)]
        public int Count { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsStickerSetCovered> Sets { get; set; }
    }
}