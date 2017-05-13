using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(539045032)]
    public class TlPhoto : TlObject
    {
        [SerializationOrder(0)]
        public TlAbsPhoto Photo { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}