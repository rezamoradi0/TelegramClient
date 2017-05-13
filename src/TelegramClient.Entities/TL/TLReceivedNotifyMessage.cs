using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1551583367)]
    public class TlReceivedNotifyMessage : TlObject
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public int Flags { get; set; }
    }
}