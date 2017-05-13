using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1878523231)]
    public class TlBlockedSlice : TlAbsBlocked
    {
        public int Count { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlContactBlocked> Blocked { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}