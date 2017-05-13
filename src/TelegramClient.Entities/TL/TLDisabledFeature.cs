using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1369215196)]
    public class TlDisabledFeature : TlObject
    {
        [SerializationOrder(0)]
        public string Feature { get; set; }

        [SerializationOrder(1)]
        public string Description { get; set; }
    }
}