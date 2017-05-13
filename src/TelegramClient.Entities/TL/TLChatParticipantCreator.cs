using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-636267638)]
    public class TlChatParticipantCreator : TlAbsChatParticipant
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }
    }
}