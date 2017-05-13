using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(342061462)]
    public class TlInputFileLocation : TlAbsInputFileLocation
    {
        [SerializationOrder(1)]
        public long VolumeId { get; set; }

        [SerializationOrder(2)]
        public int LocalId { get; set; }

        [SerializationOrder(3)]
        public long Secret { get; set; }
    }
}