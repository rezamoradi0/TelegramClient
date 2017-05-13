using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1008755359)]
    public class TlInlineBotSwitchPm : TlObject
    {
        [SerializationOrder(0)]
        public string Text { get; set; }

        [SerializationOrder(1)]
        public string StartParam { get; set; }
    }
}