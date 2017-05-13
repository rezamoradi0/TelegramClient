using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-64092740)]
    public class TlChatInviteExported : TlAbsExportedChatInvite
    {
        [SerializationOrder(0)]
        public string Link { get; set; }
    }
}