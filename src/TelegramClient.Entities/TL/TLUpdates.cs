using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1957577280)]
    public class TlUpdates : TlAbsUpdates
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsUpdate> Updates { get; set; }

        [SerializationOrder(0)]
        public TlVector<TlAbsUser> Users { get; set; }

        [SerializationOrder(0)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(0)]
        public int Date { get; set; }

        [SerializationOrder(0)]
        public int Seq { get; set; }
    }
}