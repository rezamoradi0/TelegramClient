using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-177282392)]
    public class TlChannelParticipants : TlObject
    {
        [SerializationOrder(0)]
        public int Count { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChannelParticipant> Participants { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}