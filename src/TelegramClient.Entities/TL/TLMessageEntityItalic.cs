using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2106619040)]
    public class TlMessageEntityItalic : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }
    }
}