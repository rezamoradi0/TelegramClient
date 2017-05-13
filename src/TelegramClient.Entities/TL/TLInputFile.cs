using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-181407105)]
    public class TlInputFile : TlAbsInputFile
    {
        [SerializationOrder(1)]
        public long Id { get; set; }

        [SerializationOrder(2)]
        public int Parts { get; set; }

        [SerializationOrder(3)]
        public string Name { get; set; }

        [SerializationOrder(4)]
        public string Md5Checksum { get; set; }
    }
}