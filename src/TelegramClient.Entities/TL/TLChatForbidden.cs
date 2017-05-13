using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(120753115)]
    public class TlChatForbidden : TlAbsChat
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public string Title { get; set; }
    }
}