using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(174260510)]
    public class TlRequestCheckPassword : TlMethod<TlAuthorization>
    {
        [SerializationOrder(0)]
        public byte[] PasswordHash { get; set; }
    }
}