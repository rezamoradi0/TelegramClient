using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1791935732)]
    public class TlUpdateUserPhoto : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }

        [SerializationOrder(2)]
        public TlAbsUserProfilePhoto Photo { get; set; }

        [SerializationOrder(3)]
        public bool Previous { get; set; }
    }
}