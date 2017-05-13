using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1991004873)]
    public class TlInputChatPhoto : TlAbsInputChatPhoto
    {
        [SerializationOrder(0)]
        public TlAbsInputPhoto Id { get; set; }
    }
}