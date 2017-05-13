using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-715532088)]
    public class TlUserProfilePhoto : TlAbsUserProfilePhoto
    {
        [SerializationOrder(0)]
        public long PhotoId { get; set; }

        [SerializationOrder(1)]
        public TlAbsFileLocation PhotoSmall { get; set; }

        [SerializationOrder(2)]
        public TlAbsFileLocation PhotoBig { get; set; }
    }
}