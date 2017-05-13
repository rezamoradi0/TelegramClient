using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(141781513)]
    public class TlRequestGetFullChannel : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        public Messages.TlChatFull Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (Messages.TlChatFull) ObjectUtils.DeserializeObject(br);
        }
    }
}