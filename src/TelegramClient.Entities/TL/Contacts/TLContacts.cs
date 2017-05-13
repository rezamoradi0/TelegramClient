using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1871416498)]
    public class TlContacts : TlAbsContacts
    {
        [SerializationOrder(0)]
        public TlVector<TlContact> Contacts { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}