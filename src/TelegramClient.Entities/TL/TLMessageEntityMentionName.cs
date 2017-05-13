using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(892193368)]
    public class TlMessageEntityMentionName : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }

        [SerializationOrder(2)]
        public int UserId { get; set; }
    }
}