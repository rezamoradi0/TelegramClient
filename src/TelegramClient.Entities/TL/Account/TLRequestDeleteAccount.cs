using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1099779595)]
    public class TlRequestDeleteAccount : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public string Reason { get; set; }
    }
}