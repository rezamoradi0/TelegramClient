using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-59151553)]
    public class TlKeyboardButtonRequestGeoLocation : TlAbsKeyboardButton
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}