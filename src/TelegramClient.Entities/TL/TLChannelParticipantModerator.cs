using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1861910545)]
    public class TlChannelParticipantModerator : TlAbsChannelParticipant
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public int InviterId { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }
    }
}