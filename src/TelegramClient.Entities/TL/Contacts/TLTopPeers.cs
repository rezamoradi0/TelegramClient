using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1891070632)]
    public class TlTopPeers : TlAbsTopPeers
    {
        [SerializationOrder(0)]
        public TlVector<TlTopPeerCategoryPeers> Categories { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}