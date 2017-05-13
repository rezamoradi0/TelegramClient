using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1444503762)]
    public class TlRequestEditChatAdmin : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(2)]
        public bool IsAdmin { get; set; }
    }
}