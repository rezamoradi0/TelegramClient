using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1895411046)]
    public class TlUpdateNewAuthorization : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public long AuthKeyId { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }

        [SerializationOrder(2)]
        public string Device { get; set; }

        [SerializationOrder(3)]
        public string Location { get; set; }
    }
}