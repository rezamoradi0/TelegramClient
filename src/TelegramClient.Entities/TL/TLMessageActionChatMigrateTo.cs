using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1371385889)]
    public class TlMessageActionChatMigrateTo : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public int ChannelId { get; set; }
    }
}