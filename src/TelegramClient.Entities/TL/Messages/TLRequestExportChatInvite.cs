using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2106086025)]
    public class TlRequestExportChatInvite : TlMethod
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        public TlAbsExportedChatInvite Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsExportedChatInvite) ObjectUtils.DeserializeObject(br);
        }
    }
}