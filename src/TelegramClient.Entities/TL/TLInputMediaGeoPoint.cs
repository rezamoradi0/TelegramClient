using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-104578748)]
    public class TlInputMediaGeoPoint : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public TlAbsInputGeoPoint GeoPoint { get; set; }
    }
}