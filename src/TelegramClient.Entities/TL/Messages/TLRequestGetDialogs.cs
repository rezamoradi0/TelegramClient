using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1799878989)]
    public class TlRequestGetDialogs : TlMethod
    {
        [SerializationOrder(0)]
        public int OffsetDate { get; set; }

        [SerializationOrder(1)]
        public int OffsetId { get; set; }

        [SerializationOrder(2)]
        public TlAbsInputPeer OffsetPeer { get; set; }

        [SerializationOrder(3)]
        public int Limit { get; set; }

        public TlAbsDialogs Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsDialogs) ObjectUtils.DeserializeObject(br);
        }
    }
}