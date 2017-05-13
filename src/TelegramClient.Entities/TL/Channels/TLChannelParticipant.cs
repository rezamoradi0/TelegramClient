namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-791039645)]
    public class TlChannelParticipant : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsChannelParticipant Participant { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}