using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1996904104)]
    public class TlInputAppEvent : TlObject
    {
        [SerializationOrder(0)]
        public double Time { get; set; }

        [SerializationOrder(1)]
        public string Type { get; set; }

        [SerializationOrder(2)]
        public long Peer { get; set; }

        [SerializationOrder(3)]
        public string Data { get; set; }
    }
}