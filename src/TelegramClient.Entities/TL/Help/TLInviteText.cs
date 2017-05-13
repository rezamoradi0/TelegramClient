using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(415997816)]
    public class TlInviteText : TlObject
    {
        [SerializationOrder(0)]
        public string Message { get; set; }
    }
}