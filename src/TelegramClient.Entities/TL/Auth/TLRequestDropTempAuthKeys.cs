using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1907842680)]
    public class TlRequestDropTempAuthKeys : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public TlVector<long> ExceptAuthKeys { get; set; }
    }
}