using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1462213465)]
    public class TlInputBotInlineResultPhoto : TlAbsInputBotInlineResult
    {
        [SerializationOrder(0)]
        public string Id { get; set; }

        [SerializationOrder(1)]
        public string Type { get; set; }

        [SerializationOrder(2)]
        public TlAbsInputPhoto Photo { get; set; }

        [SerializationOrder(3)]
        public TlAbsInputBotInlineMessage SendMessage { get; set; }
    }
}