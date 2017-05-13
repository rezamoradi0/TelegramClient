using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1558317424)]
    public class TlRecentStickers : TlAbsRecentStickers
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsDocument> Stickers { get; set; }
    }
}