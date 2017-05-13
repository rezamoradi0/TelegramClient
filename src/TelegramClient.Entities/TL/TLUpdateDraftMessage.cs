using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-299124375)]
    public class TlUpdateDraftMessage : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlAbsDraftMessage Draft { get; set; 
    }
}