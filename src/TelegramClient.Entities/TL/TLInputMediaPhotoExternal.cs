using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1252045032)]
    public class TlInputMediaPhotoExternal : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public string Url { get; set; }

        [SerializationOrder(1)]
        public string Caption { get; set; }
    }
}