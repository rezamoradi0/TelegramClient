using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(313694676)]
    public class TlStickerPack : TlObject
    {
        [SerializationOrder(0)]
        public string Emoticon { get; set; }

        [SerializationOrder(1)]
        public TlVector<long> Documents { get; set; }
    }
}