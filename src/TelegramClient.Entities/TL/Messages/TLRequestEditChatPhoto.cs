using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-900957736)]
    public class TlRequestEditChatPhoto : TlMethod<TlAbsUpdates>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputChatPhoto Photo { get; set; }
    }
}