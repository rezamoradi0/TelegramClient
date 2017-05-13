using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1906403213)]
    public class TlUpdateDcOptions : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlVector<TlDcOption> DcOptions { get; set; }
    }
}