using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1358175439)]
    public class TlKeyboardButtonGame : TlAbsKeyboardButton
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}