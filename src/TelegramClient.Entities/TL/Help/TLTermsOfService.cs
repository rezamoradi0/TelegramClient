using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-236044656)]
    public class TlTermsOfService : TlObject
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}