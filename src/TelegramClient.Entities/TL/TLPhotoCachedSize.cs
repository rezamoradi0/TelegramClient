using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-374917894)]
    public class TlPhotoCachedSize : TlAbsPhotoSize
    {
        [SerializationOrder(0)]
        public string Type { get; set; }

        [SerializationOrder(1)]
        public TlAbsFileLocation Location { get; set; }

        [SerializationOrder(2)]
        public int W { get; set; }

        [SerializationOrder(3)]
        public int H { get; set; }

        [SerializationOrder(4)]
        public byte[] Bytes { get; set; }
    }
}