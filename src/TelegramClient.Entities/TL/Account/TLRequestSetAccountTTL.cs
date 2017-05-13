using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(608323678)]
    public class TlRequestSetAccountTtl : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlAccountDaysTtl Ttl { get; set; }
    }
}