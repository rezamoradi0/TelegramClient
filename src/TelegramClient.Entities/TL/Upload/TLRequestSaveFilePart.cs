using System.IO;

namespace TelegramClient.Entities.TL.Upload
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1291540959)]
    public class TlRequestSaveFilePart : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public long FileId { get; set; }

        [SerializationOrder(1)]
        public int FilePart { get; set; }

        [SerializationOrder(2)]
        public byte[] Bytes { get; set; }
    }
}