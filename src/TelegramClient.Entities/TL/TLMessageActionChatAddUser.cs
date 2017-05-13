using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1217033015)]
    public class TlMessageActionChatAddUser : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public TlVector<int> Users { get; set; }
    }
}