using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1995686519)]
    public class TlInputBotInlineMessageId : TlObject
    {
        [SerializationOrder(0)]
        public int DcId { get; set; }

        [SerializationOrder(1)]
        public long Id { get; set; }

        [SerializationOrder(2)]
        public long AccessHash { get; set; }
    }
}