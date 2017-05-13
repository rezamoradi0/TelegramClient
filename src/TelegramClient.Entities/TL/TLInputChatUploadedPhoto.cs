using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1837345356)]
    public class TlInputChatUploadedPhoto : TlAbsInputChatPhoto
    {
        [SerializationOrder(0)]
        public TlAbsInputFile File { get; set; }
    }
}