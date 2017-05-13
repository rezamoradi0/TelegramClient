using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-344583728)]
    public class TlRequestEditAdmin : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(2)]
        public TlAbsChannelParticipantRole Role { get; set; }

        public TlAbsUpdates Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}