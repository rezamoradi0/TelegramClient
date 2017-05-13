using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(913498268)]
    public class TlRequestGetPeerSettings : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlPeerSettings Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlPeerSettings) ObjectUtils.DeserializeObject(br);
        }
    }
}