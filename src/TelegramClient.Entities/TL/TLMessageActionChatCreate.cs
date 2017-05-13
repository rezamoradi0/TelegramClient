using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1503425638)]
    public class TlMessageActionChatCreate : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public string Title { get; set; }

        [SerializationOrder(1)]
        public TlVector<int> Users { get; set; }
    }
}