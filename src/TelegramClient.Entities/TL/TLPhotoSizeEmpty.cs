using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(236446268)]
    public class TlPhotoSizeEmpty : TlAbsPhotoSize
    {
        [SerializationOrder(0)]
        public string Type { get; set; }
    }
}