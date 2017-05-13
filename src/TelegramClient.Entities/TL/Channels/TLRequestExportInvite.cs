using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-950663035)]
    public class TlRequestExportInvite : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        public TlAbsExportedChatInvite Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsExportedChatInvite) ObjectUtils.DeserializeObject(br);
        }
    }
}