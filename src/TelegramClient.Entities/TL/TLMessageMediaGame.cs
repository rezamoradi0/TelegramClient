using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-38694904)]
    public class TlMessageMediaGame : TlAbsMessageMedia
    {
        [SerializationOrder(0)]
        public TlGame Game { get; set; }
    }
}