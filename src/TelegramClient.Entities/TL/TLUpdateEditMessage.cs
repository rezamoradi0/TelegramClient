using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-469536605)]
    public class TlUpdateEditMessage : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsMessage Message { get; set; }

        [SerializationOrder(1)]
        public int Pts { get; set; }

        [SerializationOrder(2)]
        public int PtsCount { get; set; }
    }
}