using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1729618630)]
    public class TlBotInfo : TlObject
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }

        [SerializationOrder(1)]
        public string Description { get; set; }

        [SerializationOrder(2)]
        public TlVector<TlBotCommand> Commands { get; set; }
    }
}