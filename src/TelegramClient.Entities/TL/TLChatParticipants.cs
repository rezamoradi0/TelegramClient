using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1061556205)]
    public class TlChatParticipants : TlAbsChatParticipants
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChatParticipant> Participants { get; set; }

        [SerializationOrder(2)]
        public int Version { get; set; }
    }
}