using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1891839707)]
    public class TlRequestChangePhone : TlMethod<TlAbsUser>
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }

        [SerializationOrder(1)]
        public string PhoneCodeHash { get; set; }

        [SerializationOrder(2)]
        public string PhoneCode { get; set; }
    }
}