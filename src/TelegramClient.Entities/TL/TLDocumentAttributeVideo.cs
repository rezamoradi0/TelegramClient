using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1494273227)]
    public class TlDocumentAttributeVideo : TlAbsDocumentAttribute
    {
        [SerializationOrder(0)]
        public int Duration { get; set; }

        [SerializationOrder(1)]
        public int W { get; set; }

        [SerializationOrder(2)]
        public int H { get; set; }
    }
}