using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1336154098)]
    public class TlInputBotInlineResultGame : TlAbsInputBotInlineResult
    {
        [SerializationOrder(0)]
        public string Id { get; set; }

        [SerializationOrder(1)]
        public string ShortName { get; set; }

        [SerializationOrder(2)]
        public TlAbsInputBotInlineMessage SendMessage { get; set; }
    }
}