using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-350980120)]
    public class TlWebPageEmpty : TlAbsWebPage
    {
        [SerializationOrder(0)]
        public long Id { get; set; }
    }
}