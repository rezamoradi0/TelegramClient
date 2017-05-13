using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1694474197)]
    public class TlChats : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsChat> Chats { get; set; }
    }
}