using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-95482955)]
    public class TlInputFileBig : TlAbsInputFile
    {
        [SerializationOrder(1)]
        public long Id { get; set; }

        [SerializationOrder(2)]
        public int Parts { get; set; }

        [SerializationOrder(3)]
        public string Name { get; set; }
    }
}