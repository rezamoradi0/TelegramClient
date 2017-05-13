using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(471043349)]
    public class TlBlocked : TlAbsBlocked
    {
        [SerializationOrder(0)]
        public TlVector<TlContactBlocked> Blocked { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}