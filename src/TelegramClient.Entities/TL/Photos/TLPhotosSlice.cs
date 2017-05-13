using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(352657236)]
    public class TlPhotosSlice : TlAbsPhotos
    {
        [SerializationOrder(0)]
        public int Count { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsPhoto> Photos { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}