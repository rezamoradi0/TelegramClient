using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1757493555)]
    public class TlUpdateReadMessagesContents : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlVector<int> Messages { get; set; }

        [SerializationOrder(1)]
        public int Pts { get; set; }

        [SerializationOrder(2)]
        public int PtsCount { get; set; }
    }
}