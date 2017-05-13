using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1910543603)]
    public class TlDialogsSlice : TlAbsDialogs
    {
        [SerializationOrder(0)]
        public int Count { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlDialog> Dialogs { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsMessage> Messages { get; set; }
        
        [SerializationOrder(3)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(4)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}