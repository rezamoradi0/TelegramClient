using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-206066487)]
    public class TlInputGeoPoint : TlAbsInputGeoPoint
    {
        [SerializationOrder(0)]
        public double Lat { get; set; }

        [SerializationOrder(1)]
        public double Long { get; set; }
    }
}