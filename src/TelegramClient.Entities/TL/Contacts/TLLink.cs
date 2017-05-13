using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(986597452)]
    public class TlLink : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsContactLink MyLink { get; set; }

        [SerializationOrder(1)]
        public TlAbsContactLink ForeignLink { get; set; }

        [SerializationOrder(2)]
        public TlAbsUser User { get; set; }
    }
}