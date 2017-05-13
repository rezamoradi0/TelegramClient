using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1670052855)]
    public class TlFoundGifCached : TlAbsFoundGif
    {
        [SerializationOrder(0)]
        public string Url { get; set; }

        [SerializationOrder(1)]
        public TlAbsPhoto Photo { get; set; }

        [SerializationOrder(2)]
        public TlAbsDocument Document { get; set; }
    }
}