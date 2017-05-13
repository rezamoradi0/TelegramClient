using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-92517498)]
    public class TlRequestUpdatePasswordSettings : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public byte[] CurrentPasswordHash { get; set; }

        [SerializationOrder(1)]
        public TlPasswordInputSettings NewSettings { get; set; }
    }
}