using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1058912715)]
    public class TlDhConfigNotModified : TlAbsDhConfig
    {
        [SerializationOrder(0)]
        public byte[] Random { get; set; }
    }
}