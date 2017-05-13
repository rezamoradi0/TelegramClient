using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1851755554)]
    public class TlUpdateChatParticipantDelete : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public int UserId { get; set; }

        [SerializationOrder(2)]
        public int Version { get; set; }
    }
}