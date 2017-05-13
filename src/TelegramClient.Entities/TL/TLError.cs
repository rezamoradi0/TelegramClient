using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-994444869)]
    public class TlError : TlObject
    {
        [SerializationOrder(0)]
        public int Code { get; set; }

        [SerializationOrder(1)]
        public string Text { get; set; }
    }
}