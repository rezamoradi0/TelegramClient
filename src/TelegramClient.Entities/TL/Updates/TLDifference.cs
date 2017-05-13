using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(16030880)]
    public class TlDifference : TlAbsDifference
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsMessage> NewMessages { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsEncryptedMessage> NewEncryptedMessages { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUpdate> OtherUpdates { get; set; }

        [SerializationOrder(3)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(4)]
        public TlVector<TlAbsUser> Users { get; set; }

        [SerializationOrder(5)]
        public TlState State { get; set; }
    }
}