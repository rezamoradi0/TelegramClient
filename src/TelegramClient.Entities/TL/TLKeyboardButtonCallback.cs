using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1748655686)]
    public class TlKeyboardButtonCallback : TlAbsKeyboardButton
    {
        [SerializationOrder(0)]
        public string Text { get; set; }

        [SerializationOrder(1)]
        public byte[] Data { get; set; }
    }
}