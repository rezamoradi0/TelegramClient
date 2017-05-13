using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1713919532)]
    public class TlRequestUpdateStatus : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public bool Offline { get; set; }
    }
}