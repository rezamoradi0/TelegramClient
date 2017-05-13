using System.IO;
using TelegramClient.Entities.TL.Updates;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(863093588)]
    public class TlPeerDialogs : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlDialog> Dialogs { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsMessage> Messages { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(3)]
        public TlVector<TlAbsUser> Users { get; set; }

        [SerializationOrder(4)]
        public TlState State { get; set; }
    }
}