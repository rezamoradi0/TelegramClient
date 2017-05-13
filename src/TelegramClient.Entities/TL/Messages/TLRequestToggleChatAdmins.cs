using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-326379039)]
    public class TlRequestToggleChatAdmins : TlMethod<TlAbsUpdates>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public bool Enabled { get; set; }

        [SerializationOrder(2)]
        public TlAbsUpdates Response { get; set; }
    }
}