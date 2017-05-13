using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(618237842)]
    public class TlRequestGetParticipants : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlAbsChannelParticipantsFilter Filter { get; set; }

        [SerializationOrder(2)]
        public int Offset { get; set; }

        [SerializationOrder(3)]
        public int Limit { get; set; }

        public TlChannelParticipants Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlChannelParticipants) ObjectUtils.DeserializeObject(br);
        }
    }
}