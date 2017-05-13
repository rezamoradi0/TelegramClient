using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1548249383)]
    public class TlUpdateUserTyping : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public TlAbsSendMessageAction Action { get; set; }
    }
}