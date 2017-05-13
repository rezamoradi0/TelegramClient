using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2027216577)]
    public class TlUpdateShort : TlAbsUpdates
    {
        [SerializationOrder(0)]
        public TlAbsUpdate Update { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }
    }
}