using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(771925524)]
    public class TlChatFull : TlAbsChatFull
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public TlAbsChatParticipants Participants { get; set; }

        [SerializationOrder(2)]
        public TlAbsPhoto ChatPhoto { get; set; }

        [SerializationOrder(3)]
        public TlAbsPeerNotifySettings NotifySettings { get; set; }

        [SerializationOrder(4)]
        public TlAbsExportedChatInvite ExportedInvite { get; set; }

        [SerializationOrder(5)]
        public TlVector<TlBotInfo> BotInfo { get; set; }
    }
}