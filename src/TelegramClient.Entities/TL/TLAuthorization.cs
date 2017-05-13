using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2079516406)]
    public class TlAuthorization : TlObject
    {
        [SerializationOrder(0)]
        public long Hash { get; set; }

        [SerializationOrder(1)]
        public int Flags { get; set; }

        [SerializationOrder(2)]
        public string DeviceModel { get; set; }

        [SerializationOrder(3)]
        public string Platform { get; set; }

        [SerializationOrder(4)]
        public string SystemVersion { get; set; }

        [SerializationOrder(5)]
        public int ApiId { get; set; }

        [SerializationOrder(6)]
        public string AppName { get; set; }

        [SerializationOrder(7)]
        public string AppVersion { get; set; }

        [SerializationOrder(8)]
        public int DateCreated { get; set; }

        [SerializationOrder(9)]
        public int DateActive { get; set; }

        [SerializationOrder(10)]
        public string Ip { get; set; }

        [SerializationOrder(11)]
        public string Country { get; set; }

        [SerializationOrder(12)]
        public string Region { get; set; }
    }
}