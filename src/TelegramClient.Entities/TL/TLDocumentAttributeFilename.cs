using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(358154344)]
    public class TlDocumentAttributeFilename : TlAbsDocumentAttribute
    {
        [SerializationOrder(0)]
        public string FileName { get; set; }
    }
}