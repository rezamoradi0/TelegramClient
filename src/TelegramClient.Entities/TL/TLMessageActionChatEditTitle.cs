using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1247687078)]
    public class TlMessageActionChatEditTitle : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public string Title { get; set; }
    }
}