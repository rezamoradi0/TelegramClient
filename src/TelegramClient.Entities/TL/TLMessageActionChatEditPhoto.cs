using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2144015272)]
    public class TlMessageActionChatEditPhoto : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public TlAbsPhoto Photo { get; set; }
    }
}