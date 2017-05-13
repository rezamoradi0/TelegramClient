using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1117713463)]
    public class TlMessageEntityBold : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }
    }
}