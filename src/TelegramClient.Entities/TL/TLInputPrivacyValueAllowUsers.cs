using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(320652927)]
    public class TlInputPrivacyValueAllowUsers : TlAbsInputPrivacyRule
    { 
        [SerializationOrder(0)]
        public TlVector<TlAbsInputUser> Users { get; set; }
    }
}