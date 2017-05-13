using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(125178264)]
    public class TlUpdateChatParticipants : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsChatParticipants Participants { get; set; }
    }
}