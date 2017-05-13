using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(364538944)]
    public class TlDialogs : TlAbsDialogs
    {
        [SerializationOrder(0)]
        public TlVector<TlDialog> Dialogs { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsMessage> Messages { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(3)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}