using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(313765169)]
    public class TlRequestGetNotifySettings : TlMethod<TlAbsPeerNotifySettings>
    {
        [SerializationOrder(0)]
        public TlAbsInputNotifyPeer Peer { get; set; }
    }
}