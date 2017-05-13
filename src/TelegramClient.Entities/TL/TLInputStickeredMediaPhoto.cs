using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1251549527)]
    public class TlInputStickeredMediaPhoto : TlAbsInputStickeredMedia
    {
        [SerializationOrder(0)]
        public TlAbsInputPhoto Id { get; set; }
    }
}