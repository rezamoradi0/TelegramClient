using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(150761757)]
    public class TlRequestGetAccountTtl : TlMethod<TlAccountDaysTtl>
    {
        [SerializationOrder(0)]
        public TlAccountDaysTtl Response { get; set; }
    }
}