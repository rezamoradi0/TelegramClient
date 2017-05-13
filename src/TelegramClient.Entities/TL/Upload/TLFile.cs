using System.IO;
using TelegramClient.Entities.TL.Storage;

namespace TelegramClient.Entities.TL.Upload
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(157948117)]
    public class TlFile : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsFileType Type { get; set; }

        [SerializationOrder(1)]
        public int Mtime { get; set; }

        [SerializationOrder(2)]
        public byte[] Bytes { get; set; }
    }
}