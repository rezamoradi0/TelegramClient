using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1406570614)]
    public class TlFileLocation : TlAbsFileLocation
    {
        [SerializationOrder(0)]
        public int DcId { get; set; }

        [SerializationOrder(1)]
        public long VolumeId { get; set; }

        [SerializationOrder(2)]
        public int LocalId { get; set; }

        [SerializationOrder(3)]
        public long Secret { get; set; }
    }
}