using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-373312269)]
    public class TlInputMediaPhoto : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public TlAbsInputPhoto Id { get; set; }

        [SerializationOrder(1)]
        public string Caption { get; set; }
    }
}