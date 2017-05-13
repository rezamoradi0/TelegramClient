using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1232070311)]
    public class TlUpdateChatParticipantAdmin : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public int UserId { get; set; }

        [SerializationOrder(2)]
        public bool IsAdmin { get; set; }

        [SerializationOrder(3)]
        public int Version { get; set; }
    }
}