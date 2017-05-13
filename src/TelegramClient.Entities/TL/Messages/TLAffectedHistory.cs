using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1269012015)]
    public class TlAffectedHistory : TlObject
    {
        [SerializationOrder(0)]
        public int Pts { get; set; }

        [SerializationOrder(1)]
        public int PtsCount { get; set; }

        [SerializationOrder(2)]
        public int Offset { get; set; }
    }
}