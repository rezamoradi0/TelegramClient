using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1460572005)]
    public class TlRequestHideReportSpam : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        public bool Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}