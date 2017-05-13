using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(546203849)]
    public class TlInputMessageEntityMentionName : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }

        [SerializationOrder(2)]
        public TlAbsInputUser UserId { get; set; }
    }
}