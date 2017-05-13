using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(522914557)]
    public class TlUpdateNewMessage : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsMessage Message { get; set; }

        [SerializationOrder(1)]
        public int Pts { get; set; }

        [SerializationOrder(2)]
        public int PtsCount { get; set; }
    }
}