using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1918567619)]
    public class TlUpdatesCombined : TlAbsUpdates
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsUpdate> Updates { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(3)]
        public int Date { get; set; }

        [SerializationOrder(4)]
        public int SeqStart { get; set; }

        [SerializationOrder(5)]
        public int Seq { get; set; }
    }
}