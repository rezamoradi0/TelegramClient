using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1938715001)]
    public class TlMessages : TlAbsMessages
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsMessage> Messages { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}