using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1148011883)]
    public class TlMessageEntityUnknown : TlAbsMessageEntity
    {
        [SerializationOrder(1)]
        public int Offset { get; set; }

        [SerializationOrder(2)]
        public int Length { get; set; }
    }
}