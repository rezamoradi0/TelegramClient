using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-364179876)]
    public class TlUpdateChatParticipantAdd : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public int UserId { get; set; }

        [SerializationOrder(2)]
        public int InviterId { get; set; }

        [SerializationOrder(3)]
        public int Date { get; set; }

        [SerializationOrder(4)]
        public int Version { get; set; }
    }
}