using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1417756512)]
    public class TlEncryptedChatEmpty : TlAbsEncryptedChat
    {
        [SerializationOrder(0)]
        public int Id { get; set; }
    }
}