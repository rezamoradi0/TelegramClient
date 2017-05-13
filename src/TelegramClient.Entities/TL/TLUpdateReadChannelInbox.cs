using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1108669311)]
    public class TlUpdateReadChannelInbox : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }

        [SerializationOrder(0)]
        public int MaxId { get; set; }
    }
}