using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1297858060)]
    public class TlPrivacyValueAllowUsers : TlAbsPrivacyRule
    {
        [SerializationOrder(0)]
        public TlVector<int> Users { get; set; }
    }
}