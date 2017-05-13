using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(209668535)]
    public class TlPrivacyValueDisallowUsers : TlAbsPrivacyRule
    {
        [SerializationOrder(0)]
        public TlVector<int> Users { get; set; }
    }
}