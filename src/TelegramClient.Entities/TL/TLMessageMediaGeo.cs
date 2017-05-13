using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1457575028)]
    public class TlMessageMediaGeo : TlAbsMessageMedia
    {
        [SerializationOrder(0)]
        public TlAbsGeoPoint Geo { get; set; }
    }
}