using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(673687578)]
    public class TlInputMediaVenue : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public TlAbsInputGeoPoint GeoPoint { get; set; }

        [SerializationOrder(1)]
        public string Title { get; set; }

        [SerializationOrder(2)]
        public string Address { get; set; }

        [SerializationOrder(3)]
        public string Provider { get; set; }

        [SerializationOrder(4)]
        public string VenueId { get; set; }
    }
}