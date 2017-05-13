using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-125240806)]
    public class TlPrivacyValueDisallowContacts : TlAbsPrivacyRule
    {
    }
}