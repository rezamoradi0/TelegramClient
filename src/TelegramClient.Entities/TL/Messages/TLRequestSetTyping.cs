using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1551737264)]
    public class TlRequestSetTyping : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlAbsSendMessageAction Action { get; set; }
    }
}