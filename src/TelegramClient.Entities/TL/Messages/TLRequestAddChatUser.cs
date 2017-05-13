using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-106911223)]
    public class TlRequestAddChatUser : TlMethod<TlAbsUpdates>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(2)]
        public int FwdLimit { get; set; }
    }
}