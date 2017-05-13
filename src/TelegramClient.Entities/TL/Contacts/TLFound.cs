using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(446822276)]
    public class TlFound : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsPeer> Results { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsChat> Chats { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}