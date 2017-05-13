using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(629866245)]
    public class TlKeyboardButtonUrl : TlAbsKeyboardButton
    {
        [SerializationOrder(0)]
        public string Text { get; set; }

        [SerializationOrder(1)]
        public string Url { get; set; }
    }
}