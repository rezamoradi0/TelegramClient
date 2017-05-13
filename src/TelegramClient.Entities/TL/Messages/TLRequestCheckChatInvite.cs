using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1051570619)]
    public class TlRequestCheckChatInvite : TlMethod<TlAbsChatInvite>
    {
        [SerializationOrder(0)]
        public string Hash { get; set; }
    }
}