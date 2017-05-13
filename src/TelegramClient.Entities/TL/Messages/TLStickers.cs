using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1970352846)]
    public class TlStickers : TlAbsStickers
    {
        [SerializationOrder(0)]
        public string Hash { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsDocument> Stickers { get; set; }
        
    }
}