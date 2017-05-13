using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1212395773)]
    public class TlInputMediaGifExternal : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public string Url { get; set; }

        [SerializationOrder(1)]
        public string Q { get; set; }
    }
}