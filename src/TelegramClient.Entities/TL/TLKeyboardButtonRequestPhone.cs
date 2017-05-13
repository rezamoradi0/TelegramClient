using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1318425559)]
    public class TlKeyboardButtonRequestPhone : TlAbsKeyboardButton
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}