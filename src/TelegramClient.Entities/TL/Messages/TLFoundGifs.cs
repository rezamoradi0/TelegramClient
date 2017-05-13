using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1158290442)]
    public class TlFoundGifs : TlObject
    {
        [SerializationOrder(0)]
        public int NextOffset { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsFoundGif> Results { get; set; }
    }
}