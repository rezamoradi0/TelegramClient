using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2066640507)]
    public class TlAffectedMessages : TlObject
    {
        [SerializationOrder(0)]
        public int Pts { get; set; }

        [SerializationOrder(1)]
        public int PtsCount { get; set; }
    }
}