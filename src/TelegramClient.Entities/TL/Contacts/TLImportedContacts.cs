using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1387117803)]
    public class TlImportedContacts : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlImportedContact> Imported { get; set; }

        [SerializationOrder(1)]
        public TlVector<long> RetryContacts { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}