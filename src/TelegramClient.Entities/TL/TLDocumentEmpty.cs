using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(922273905)]
    public class TlDocumentEmpty : TlAbsDocument
    {
        [SerializationOrder(0)]
        public long Id { get; set; }
    }
}