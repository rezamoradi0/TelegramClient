using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1194283041)]
    public class TlAccountDaysTtl : TlObject
    {
        [SerializationOrder(0)]
        public int Days { get; set; }
    }
}