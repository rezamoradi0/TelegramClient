using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-993483427)]
    public class TlRequestGetMessagesViews : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlVector<int> Id { get; set; }

        [SerializationOrder(2)]
        public bool Increment { get; set; }

        [SerializationOrder(3)]
        public TlVector<int> Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<int>(br);
        }
    }
}