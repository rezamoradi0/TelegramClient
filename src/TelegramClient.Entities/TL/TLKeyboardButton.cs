using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1560655744)]
    public class TlKeyboardButton : TlAbsKeyboardButton
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}