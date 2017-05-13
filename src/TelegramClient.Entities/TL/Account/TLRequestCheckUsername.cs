using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(655677548)]
    public class TlRequestCheckUsername : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public string Username { get; set; }
    }
}