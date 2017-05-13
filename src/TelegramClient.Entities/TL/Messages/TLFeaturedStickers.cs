using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-123893531)]
    public class TlFeaturedStickers : TlAbsFeaturedStickers
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsStickerSetCovered> Sets { get; set; }

        [SerializationOrder(2)]
        public TlVector<long> Unread { get; set; }
    }
}