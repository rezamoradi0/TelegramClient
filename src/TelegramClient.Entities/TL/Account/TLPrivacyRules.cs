using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1430961007)]
    public class TlPrivacyRules : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsPrivacyRule> Rules { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}