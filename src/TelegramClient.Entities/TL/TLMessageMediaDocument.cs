using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-203411800)]
    public class TlMessageMediaDocument : TlAbsMessageMedia
    {
        [SerializationOrder(0)]
        public TlAbsDocument Document { get; set; }

        [SerializationOrder(1)]
        public string Caption { get; set; }
    }
}