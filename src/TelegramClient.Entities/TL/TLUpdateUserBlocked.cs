using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2131957734)]
    public class TlUpdateUserBlocked : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public bool Blocked { get; set; 
    }
}