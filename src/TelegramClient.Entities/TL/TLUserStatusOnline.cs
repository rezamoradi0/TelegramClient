using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-306628279)]
    public class TlUserStatusOnline : TlAbsUserStatus
    {
        [SerializationOrder(0)]
        public int Expires { get; set; }
    }
}