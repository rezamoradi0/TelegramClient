using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2044933984)]
    public class TlInputStickerSetShortName : TlAbsInputStickerSet
    {
        [SerializationOrder(0)]
        public string ShortName { get; set; }
    }
}