using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-668391402)]
    public class TlInputUser : TlAbsInputUser
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public long AccessHash { get; set; }
    }
}