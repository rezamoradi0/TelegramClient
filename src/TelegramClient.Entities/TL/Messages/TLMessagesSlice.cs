using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(189033187)]
    public class TlMessagesSlice : TlAbsMessages
    {
        [SerializationOrder(0)]
        public int Count { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsMessage> Messages { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(3)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}