using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(942527460)]
    public class TlUpdateServiceNotification : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public string Type { get; set; }

        [SerializationOrder(1)]
        public string Message { get; set; }

        [SerializationOrder(2)]
        public TlAbsMessageMedia Media { get; set; }

        [SerializationOrder(3)]
        public bool Popup { get; set; }
    }
}