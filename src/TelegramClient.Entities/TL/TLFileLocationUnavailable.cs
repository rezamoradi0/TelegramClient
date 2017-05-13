using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2086234950)]
    public class TlFileLocationUnavailable : TlAbsFileLocation
    {
        [SerializationOrder(0)]
        public long VolumeId { get; set; }

        [SerializationOrder(1)]
        public int LocalId { get; set; }

        [SerializationOrder(2)]
        public long Secret { get; set; }
    }
}