using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1877932953)]
    public class TlInputPrivacyValueDisallowUsers : TlAbsInputPrivacyRule
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputUser> Users { get; set; }
    }
}