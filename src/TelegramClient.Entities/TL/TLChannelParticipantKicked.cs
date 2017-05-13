using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1933187430)]
    public class TlChannelParticipantKicked : TlAbsChannelParticipant
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public int KickedBy { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }
    }
}