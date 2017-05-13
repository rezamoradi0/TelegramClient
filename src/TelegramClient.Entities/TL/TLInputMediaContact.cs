using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1494984313)]
    public class TlInputMediaContact : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }

        [SerializationOrder(2)]
        public string FirstName { get; set; }

        [SerializationOrder(3)]
        public string LastName { get; set; }
    }
}