using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-298113238)]
    public class TlUpdatePrivacy : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsPrivacyKey Key { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsPrivacyRule> Rules { get; set; }
    }
}