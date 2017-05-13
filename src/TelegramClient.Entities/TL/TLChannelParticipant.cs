using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(367766557)]
    public class TlChannelParticipant : TlAbsChannelParticipant
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }
    }
}