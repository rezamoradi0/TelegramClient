using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1657903163)]
    public class TlUpdateContactLink : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public TlAbsContactLink MyLink { get; set; }

        [SerializationOrder(2)]
        public TlAbsContactLink ForeignLink { get; set; }
    }
}