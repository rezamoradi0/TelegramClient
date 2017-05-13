using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2067899501)]
    public class TlRequestUpdateNotifySettings : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputNotifyPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlInputPeerNotifySettings Settings { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}