using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1125058340)]
    public class TlInputDocumentFileLocation : TlAbsInputFileLocation
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }

        [SerializationOrder(2)]
        public int Version { get; set; }
    }
}