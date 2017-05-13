using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(326715557)]
    public class TlPasswordRecovery : TlObject
    {
        [SerializationOrder(0)]
        public string EmailPattern { get; set; }
    }
}