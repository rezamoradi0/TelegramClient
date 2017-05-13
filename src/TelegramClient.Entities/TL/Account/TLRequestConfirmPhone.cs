using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1596029123)]
    public class TlRequestConfirmPhone : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public string PhoneCodeHash { get; set; }

        [SerializationOrder(1)]
        public string PhoneCode { get; set; }
    }
}