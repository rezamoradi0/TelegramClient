using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(954152242)]
    public class TlRequestUpdateDeviceLocked : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public int Period { get; set; }
    }
}