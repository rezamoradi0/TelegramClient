using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1020139510)]
    public class TlInputGameShortName : TlAbsInputGame
    {
        [SerializationOrder(1)]
        public TlAbsInputUser BotId { get; set; }

        [SerializationOrder(2)]
        public string ShortName { get; set; }
    }
}