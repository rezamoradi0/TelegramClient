using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1764049896)]
    public class TlNoPassword : TlAbsPassword
    {
        [SerializationOrder(0)]
        public byte[] NewSalt { get; set; }

        [SerializationOrder(1)]
        public string EmailUnconfirmedPattern { get; set; }
    }
}