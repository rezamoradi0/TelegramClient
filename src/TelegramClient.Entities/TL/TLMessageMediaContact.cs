using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1585262393)]
    public class TlMessageMediaContact : TlAbsMessageMedia
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }

        [SerializationOrder(1)]
        public string FirstName { get; set; }

        [SerializationOrder(2)]
        public string LastName { get; set; }

        [SerializationOrder(3)]
        public int UserId { get; set; }
    }
}