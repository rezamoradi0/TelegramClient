using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1032140601)]
    public class TlBotCommand : TlObject
    {
        [SerializationOrder(0)]
        public string Command { get; set; }

        [SerializationOrder(1)]
        public string Description { get; set; }
    }
}