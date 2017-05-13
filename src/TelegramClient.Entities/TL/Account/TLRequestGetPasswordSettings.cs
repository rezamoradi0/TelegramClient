using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1131605573)]
    public class TlRequestGetPasswordSettings : TlMethod<TlPasswordSettings>
    {
        [SerializationOrder(0)]
        public byte[] CurrentPasswordHash { get; set; }
    }
}