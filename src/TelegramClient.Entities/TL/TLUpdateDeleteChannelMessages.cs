using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1015733815)]
    public class TlUpdateDeleteChannelMessages : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }

        [SerializationOrder(1)]
        public TlVector<int> Messages { get; set; }

        [SerializationOrder(2)]
        public int Pts { get; set; }

        [SerializationOrder(3)]
        public int PtsCount { get; set; }
    }
}