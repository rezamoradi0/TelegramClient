using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1343524562)]
    public class TlInputChannel : TlAbsInputChannel
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}