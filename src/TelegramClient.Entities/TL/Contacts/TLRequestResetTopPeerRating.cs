using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(451113900)]
    public class TlRequestResetTopPeerRating : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsTopPeerCategory Category { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputPeer Peer { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}