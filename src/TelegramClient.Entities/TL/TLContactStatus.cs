using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-748155807)]
    public class TlContactStatus : TlObject
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public TlAbsUserStatus Status { get; set; }
    }
}