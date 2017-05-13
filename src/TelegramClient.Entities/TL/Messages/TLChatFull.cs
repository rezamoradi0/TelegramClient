using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-438840932)]
    public class TlChatFull : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsChatFull FullChat { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}