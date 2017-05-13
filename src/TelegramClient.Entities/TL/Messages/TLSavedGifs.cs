using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(772213157)]
    public class TlSavedGifs : TlAbsSavedGifs
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsDocument> Gifs { get; set; }
    }
}