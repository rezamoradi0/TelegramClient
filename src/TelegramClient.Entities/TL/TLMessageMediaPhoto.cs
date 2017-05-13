using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1032643901)]
    public class TlMessageMediaPhoto : TlAbsMessageMedia
    {
        [SerializationOrder(0)]
        public TlAbsPhoto Photo { get; set; }

        [SerializationOrder(1)]
        public string Caption { get; set; }
    }
}