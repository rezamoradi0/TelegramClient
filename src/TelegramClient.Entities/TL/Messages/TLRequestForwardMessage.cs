using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(865483769)]
    public class TlRequestForwardMessage : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(0)]
        public long RandomId { get; set; }

        public TlAbsUpdates Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUpdates) ObjectUtils.DeserializeObject(br);
        }
    }
}