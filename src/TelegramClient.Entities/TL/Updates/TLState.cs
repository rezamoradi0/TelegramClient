using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1519637954)]
    public class TlState : TlObject
    {
        [SerializationOrder(0)]
        public int Pts { get; set; }

        [SerializationOrder(1)]
        public int Qts { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }

        [SerializationOrder(3)]
        public int Seq { get; set; }

        [SerializationOrder(4)]
        public int UnreadCount { get; set; }
    }
}