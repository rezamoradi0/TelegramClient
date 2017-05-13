using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2067899501)]
    public class TlRequestUpdateNotifySettings : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlAbsInputNotifyPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlInputPeerNotifySettings Settings { get; set; }
    }
}