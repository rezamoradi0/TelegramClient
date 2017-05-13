using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1374118561)]
    public class TlRequestReportPeer : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public TlAbsReportReason Reason { get; set; }
    }
}