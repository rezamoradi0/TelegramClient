using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1516793212)]
    public class TlChatInviteAlready : TlAbsChatInvite
    {
        [SerializationOrder(0)]
        public TlAbsChat Chat { get; set; }
    }
}