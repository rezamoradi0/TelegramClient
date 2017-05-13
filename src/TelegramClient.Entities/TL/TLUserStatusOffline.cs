using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(9203775)]
    public class TlUserStatusOffline : TlAbsUserStatus
    {
        [SerializationOrder(0)]
        public int WasOnline { get; set; }
    }
}