using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1815593308)]
    public class TlDocumentAttributeImageSize : TlAbsDocumentAttribute
    {
        [SerializationOrder(0)]
        public int W { get; set; }

        [SerializationOrder(1)]
        public int H { get; set; }
        
    }
}