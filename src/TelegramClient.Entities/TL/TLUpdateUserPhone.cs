using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(314130811)]
    public class TlUpdateUserPhone : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public string Phone { get; set; }
    }
}