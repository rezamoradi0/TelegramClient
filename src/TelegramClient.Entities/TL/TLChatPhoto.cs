using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1632839530)]
    public class TlChatPhoto : TlAbsChatPhoto
    {
        [SerializationOrder(0)]
        public TlAbsFileLocation PhotoSmall { get; set; }

        [SerializationOrder(1)]
        public TlAbsFileLocation PhotoBig { get; set; }
    }
}