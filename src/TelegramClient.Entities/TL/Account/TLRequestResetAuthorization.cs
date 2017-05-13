using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-545786948)]
    public class TlRequestResetAuthorization : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public long Hash { get; set; }
    }
}