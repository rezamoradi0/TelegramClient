using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-212740181)]
    public class TlSendMessageUploadAudioAction : TlAbsSendMessageAction
    {
        [SerializationOrder(0)]
        public int Progress { get; set; }
    }
}