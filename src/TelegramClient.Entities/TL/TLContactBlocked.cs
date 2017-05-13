using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1444661369)]
    public class TlContactBlocked : TlObject
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }
    }
}