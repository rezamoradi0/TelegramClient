using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1704596961)]
    public class TlUpdateChatUserTyping : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public int UserId { get; set; }

        [SerializationOrder(2)]
        public TlAbsSendMessageAction Action { get; set; }
    }
}