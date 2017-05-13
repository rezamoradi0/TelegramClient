using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2128698738)]
    public class TlCheckedPhone : TlObject
    {
        [SerializationOrder(0)]
        public bool PhoneRegistered { get; set; }
    }
}