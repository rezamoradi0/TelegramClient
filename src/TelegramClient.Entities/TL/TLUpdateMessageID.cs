using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1318109142)]
    public class TlUpdateMessageId : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public long RandomId { get; set; }
    }
}