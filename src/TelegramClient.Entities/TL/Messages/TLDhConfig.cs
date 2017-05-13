using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(740433629)]
    public class TlDhConfig : TlAbsDhConfig
    {
        [SerializationOrder(0)]
        public int G { get; set; }

        [SerializationOrder(1)]
        public byte[] P { get; set; }

        [SerializationOrder(2)]
        public int Version { get; set; }

        [SerializationOrder(3)]
        public byte[] Random { get; set; }

    }
}