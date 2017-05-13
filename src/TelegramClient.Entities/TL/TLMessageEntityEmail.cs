using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1692693954)]
    public class TlMessageEntityEmail : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }
    }
}