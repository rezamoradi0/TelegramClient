using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-421563528)]
    public class TlRequestStartBot : TlMethod<TlAbsUpdates>
    {
        [SerializationOrder(0)]
        public TlAbsInputUser Bot { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(2)]
        public long RandomId { get; set; }

        [SerializationOrder(3)]
        public string StartParam { get; set; }
    }
}