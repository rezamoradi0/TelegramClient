using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(372165663)]
    public class TlFoundGif : TlAbsFoundGif
    {
        [SerializationOrder(0)]
        public string Url { get; set; }

        [SerializationOrder(1)]
        public string ThumbUrl { get; set; }

        [SerializationOrder(2)]
        public string ContentUrl { get; set; }

        [SerializationOrder(3)]
        public string ContentType { get; set; }

        [SerializationOrder(4)]
        public int W { get; set; }

        [SerializationOrder(5)]
        public int H { get; set; }
    }
}