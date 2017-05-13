using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-123931160)]
    public class TlMessageActionChatJoinedByLink : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public int InviterId { get; set; }
    }
}