using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(70813275)]
    public class TlInputStickeredMediaDocument : TlAbsInputStickeredMedia
    {
        [SerializationOrder(0)]
        public TlAbsInputDocument Id { get; set; }
    }
}