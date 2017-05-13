using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-906486552)]
    public class TlRequestSetPrivacy : TlMethod<TlPrivacyRules>
    {
        [SerializationOrder(0)]
        public TlAbsInputPrivacyKey Key { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsInputPrivacyRule> Rules { get; set; }
    }
}