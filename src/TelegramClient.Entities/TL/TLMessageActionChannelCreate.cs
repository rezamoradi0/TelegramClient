using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1781355374)]
    public class TlMessageActionChannelCreate : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public string Title { get; set; }
    }
}