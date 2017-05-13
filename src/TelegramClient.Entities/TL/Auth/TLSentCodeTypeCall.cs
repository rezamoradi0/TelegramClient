using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1398007207)]
    public class TlSentCodeTypeCall : TlAbsSentCodeType
    {
        [SerializationOrder(0)]
        public int Length { get; set; }
    }
}