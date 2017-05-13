using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2131196633)]
    public class TlResolvedPeer : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}