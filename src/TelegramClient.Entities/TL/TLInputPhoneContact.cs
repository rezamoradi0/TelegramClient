using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-208488460)]
    public class TlInputPhoneContact : TlObject
    {
        [SerializationOrder(0)]
        public long ClientId { get; set; }

        [SerializationOrder(1)]
        public string Phone { get; set; }

        [SerializationOrder(2)]
        public string FirstName { get; set; }

        [SerializationOrder(3)]
        public string LastName { get; set; }
    }
}