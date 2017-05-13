using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-623130288)]
    public class TlRequestGetPrivacy : TlMethod<TlPrivacyRules>
    {
        [SerializationOrder(0)]
        public TlAbsInputPrivacyKey Key { get; set; }
    }
}