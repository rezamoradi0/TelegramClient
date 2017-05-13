using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1707432768)]
    public class TlRequestUnregisterDevice : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public int TokenType { get; set; }

        [SerializationOrder(1)]
        public string Token { get; set; }
    }
}