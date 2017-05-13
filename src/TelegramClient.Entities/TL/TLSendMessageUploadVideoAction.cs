using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-378127636)]
    public class TlSendMessageUploadVideoAction : TlAbsSendMessageAction
    {
        [SerializationOrder(0)]
        public int Progress { get; set; }
    }
}