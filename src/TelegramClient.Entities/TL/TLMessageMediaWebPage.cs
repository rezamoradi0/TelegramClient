using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1557277184)]
    public class TlMessageMediaWebPage : TlAbsMessageMedia
    {
        [SerializationOrder(0)]
        public TlAbsWebPage Webpage { get; set; }
    }
}