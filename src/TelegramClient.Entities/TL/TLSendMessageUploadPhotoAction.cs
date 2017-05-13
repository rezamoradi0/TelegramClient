using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-774682074)]
    public class TlSendMessageUploadPhotoAction : TlAbsSendMessageAction
    {
        [SerializationOrder(0)]
        public int Progress { get; set; }
    }
}