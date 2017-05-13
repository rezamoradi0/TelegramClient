using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2031374829)]
    public class TlRequestSetEncryptedTyping : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlInputEncryptedChat Peer { get; set; }

        [SerializationOrder(1)]
        public bool Typing { get; set; }
    }
}