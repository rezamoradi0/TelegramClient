using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(332848423)]
    public class TlEncryptedChatDiscarded : TlAbsEncryptedChat
    {
        [SerializationOrder(0)]
        public int Id { get; set; }
    }
}