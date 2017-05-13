using System.IO;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-32999408)]
    public class TlRequestReportSpam : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(2)]
        public TlVector<int> Id { get; set; }

        public bool Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}