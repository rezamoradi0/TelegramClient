using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-100378723)]
    public class TlMessageEntityMention : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }
    }
}