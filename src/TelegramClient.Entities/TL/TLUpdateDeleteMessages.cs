using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1576161051)]
    public class TlUpdateDeleteMessages : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlVector<int> Messages { get; set; }

        [SerializationOrder(1)]
        public int Pts { get; set; }

        [SerializationOrder(2)]
        public int PtsCount { get; set; }
    }
}