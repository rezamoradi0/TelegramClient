using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(628472761)]
    public class TlUpdateContactRegistered : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public int UserId { get; set; }
        
        [SerializationOrder(1)]
        public int Date { get; set; }
    }
}