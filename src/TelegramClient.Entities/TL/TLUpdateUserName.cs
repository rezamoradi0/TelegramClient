using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1489818765)]
    public class TlUpdateUserName : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public string FirstName { get; set; }

        [SerializationOrder(2)]
        public string LastName { get; set; }

        [SerializationOrder(3)]
        public string Username { get; set; }
    }
}