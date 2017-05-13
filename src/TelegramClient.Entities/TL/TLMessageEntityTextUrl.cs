using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1990644519)]
    public class TlMessageEntityTextUrl : TlAbsMessageEntity
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Length { get; set; }

        [SerializationOrder(2)]
        public string Url { get; set; }
    }
}