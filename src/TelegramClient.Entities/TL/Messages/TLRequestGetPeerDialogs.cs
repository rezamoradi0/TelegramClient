using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(764901049)]
    public class TlRequestGetPeerDialogs : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputPeer> Peers { get; set; }

        public TlPeerDialogs Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlPeerDialogs) ObjectUtils.DeserializeObject(br);
        }
    }
}