using System.IO;

namespace TelegramClient.Entities.TL.Help
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1181279933)]
    public class TlAppChangelog : TlAbsAppChangelog
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}