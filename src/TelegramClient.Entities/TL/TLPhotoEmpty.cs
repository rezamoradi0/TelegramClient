using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(590459437)]
    public class TlPhotoEmpty : TlAbsPhoto
    {
        [SerializationOrder(0)]
        public long Id { get; set; }
    }
}