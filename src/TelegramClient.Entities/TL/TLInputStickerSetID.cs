using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1645763991)]
    public class TlInputStickerSetId : TlAbsInputStickerSet
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}