using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-471670279)]
    public class TlChannelParticipantCreator : TlAbsChannelParticipant
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }
    }
}