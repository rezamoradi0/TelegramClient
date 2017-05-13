using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-981018084)]
    public class TlWebPagePending : TlAbsWebPage
    {
        [SerializationOrder(0)]
        public long Id { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }
    }
}