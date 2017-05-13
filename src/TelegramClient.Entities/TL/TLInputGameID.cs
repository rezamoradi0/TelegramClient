using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(53231223)]
    public class TlInputGameId : TlAbsInputGame
    {
        [SerializationOrder(1)]
        public long Id { get; set; }

        [SerializationOrder(2)]
        public long AccessHash { get; set; }
    }
}