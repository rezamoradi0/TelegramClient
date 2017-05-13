using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-512463606)]
    public class TlInputReportReasonOther : TlAbsReportReason
    {
        [SerializationOrder(0)]
        public string Text { get; set; }
    }
}