using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-530505962)]
    public class TlRequestDeleteChatUser : TlMethod<TlAbsUpdates>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }
    }
}