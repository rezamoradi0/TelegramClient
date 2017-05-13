using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(182649427)]
    public class TlMessageRange : TlObject
    {
        [SerializationOrder(0)]
        public int MinId { get; set; }

        [SerializationOrder(1)]
        public int MaxId { get; set; }
    }
}