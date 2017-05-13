using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1109531342)]
    public class TlPeerChannel : TlAbsPeer
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }
    }
}