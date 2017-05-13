using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2139689491)]
    public class TlUpdateWebPage : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsWebPage Webpage { get; set; }

        [SerializationOrder(1)]
        public int Pts { get; set; }

        [SerializationOrder(2)]
        public int PtsCount { get; set; }
    }
}