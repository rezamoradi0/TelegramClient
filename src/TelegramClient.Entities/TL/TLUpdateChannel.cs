using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1227598250)]
    public class TlUpdateChannel : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }
    }
}