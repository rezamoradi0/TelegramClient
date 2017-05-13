using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-421563528)]
    public class TlRequestStartBot : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputUser Bot { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputPeer Peer { get; set; }
        public long RandomId { get; set; }

        public string StartParam { get; set; }
        [SerializationOrder(2)]
        
        public TlAbsUpdates Response { get; set; }


        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}