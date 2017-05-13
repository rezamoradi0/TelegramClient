using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1877286395)]
    public class TlRequestCheckPhone : TlMethod<TlCheckedPhone>
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }
    }
}