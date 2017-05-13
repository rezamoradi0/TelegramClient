using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-860866985)]
    public class TlWallPaper : TlAbsWallPaper
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public string Title { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsPhotoSize> Sizes { get; set; }

        [SerializationOrder(3)]
        public int Color { get; set; }
    }
}