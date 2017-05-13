using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1910892683)]
    public class TlNearestDc : TlObject
    {
        [SerializationOrder(0)]
        public string Country { get; set; }

        [SerializationOrder(1)]
        public int ThisDc { get; set; }

        [SerializationOrder(2)]
        public int NearestDc { get; set; }
    }
}