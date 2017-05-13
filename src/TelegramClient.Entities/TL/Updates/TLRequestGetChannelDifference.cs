using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1154295872)]
    public class TlRequestGetChannelDifference : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlAbsChannelMessagesFilter Filter { get; set; }

        [SerializationOrder(2)]
        public int Pts { get; set; }

        [SerializationOrder(3)]
        public int Limit { get; set; }

        public TlAbsChannelDifference Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsChannelDifference) ObjectUtils.DeserializeObject(br);
        }
    }
}