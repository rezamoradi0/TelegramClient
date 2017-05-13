using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2082087340)]
    public class TlMessageEmpty : TlAbsMessage
    {
        [SerializationOrder(0)]
        public int Id { get; set; }
    }
}