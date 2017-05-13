using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1441998364)]
    public class TlSendMessageUploadDocumentAction : TlAbsSendMessageAction
    {
        [SerializationOrder(0)]
        public int Progress { get; set; }
    }
}