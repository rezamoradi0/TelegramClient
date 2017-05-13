using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-599447467)]
    public class TlRequestEditChatTitle : TlMethod<TlAbsUpdates>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public string Title { get; set; }
    }
}