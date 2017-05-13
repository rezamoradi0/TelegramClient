using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(520357240)]
    public class TlRequestCancelCode : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }

        [SerializationOrder(1)]
        public string PhoneCodeHash { get; set; }
    }
}