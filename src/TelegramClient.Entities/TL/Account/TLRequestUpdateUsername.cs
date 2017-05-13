using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1040964988)]
    public class TlRequestUpdateUsername : TlMethod<TlAbsUser>
    {
        [SerializationOrder(0)]
        public string Username { get; set; }
    }
}