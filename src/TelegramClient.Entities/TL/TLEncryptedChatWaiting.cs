using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1006044124)]
    public class TlEncryptedChatWaiting : TlAbsEncryptedChat
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }

        [SerializationOrder(2)]
        public int Date { get; set; }

        [SerializationOrder(3)]
        public int AdminId { get; set; }

        [SerializationOrder(4)]
        public int ParticipantId { get; set; }
    }
}