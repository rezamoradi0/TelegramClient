using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(313765169)]
    public class TlRequestGetNotifySettings : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputNotifyPeer Peer { get; set; }

        public TlAbsPeerNotifySettings Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsPeerNotifySettings) ObjectUtils.DeserializeObject(br);
        }
    }
}