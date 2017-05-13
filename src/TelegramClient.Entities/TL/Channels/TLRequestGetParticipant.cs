using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1416484774)]
    public class TlRequestGetParticipant : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        public TlChannelParticipant Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlChannelParticipant) ObjectUtils.DeserializeObject(br);
        }
    }
}