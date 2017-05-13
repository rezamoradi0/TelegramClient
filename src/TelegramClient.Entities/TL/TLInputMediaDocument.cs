using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(444068508)]
    public class TlInputMediaDocument : TlAbsInputMedia
    {

        [SerializationOrder(0)]
        public TlAbsInputDocument Id { get; set; }

        [SerializationOrder(1)]
        public string Caption { get; set; }
    }
}