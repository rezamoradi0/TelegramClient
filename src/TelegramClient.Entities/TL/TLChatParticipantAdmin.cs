using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-489233354)]
    public class TlChatParticipantAdmin : TlAbsChatParticipant
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public int InviterId { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }
    }
}