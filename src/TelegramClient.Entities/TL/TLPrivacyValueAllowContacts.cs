using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-123988)]
    public class TlPrivacyValueAllowContacts : TlAbsPrivacyRule
    {
    }
}