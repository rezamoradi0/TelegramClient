using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-39416522)]
    public class TlRequestGetMessageEditData : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public int Id { get; set; }

        public TlMessageEditData Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlMessageEditData) ObjectUtils.DeserializeObject(br);
        }
    }
}