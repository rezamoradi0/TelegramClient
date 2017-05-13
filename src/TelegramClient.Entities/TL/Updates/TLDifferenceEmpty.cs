using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1567990072)]
    public class TlDifferenceEmpty : TlAbsDifference
    {
        [SerializationOrder(0)]
        public int Date { get; set; }

        [SerializationOrder(1)]
        public int Seq { get; set; }
    }
}