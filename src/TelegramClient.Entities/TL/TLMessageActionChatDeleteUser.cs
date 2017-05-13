using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1297179892)]
    public class TlMessageActionChatDeleteUser : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }
    }
}