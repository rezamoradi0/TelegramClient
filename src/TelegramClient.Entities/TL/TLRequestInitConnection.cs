using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1769565673)]
    public class TlRequestInitConnection : TlMethod
    {
        [SerializationOrder(0)]
        public int ApiId { get; set; }

        [SerializationOrder(1)]
        public string DeviceModel { get; set; }

        [SerializationOrder(2)]
        public string SystemVersion { get; set; }

        [SerializationOrder(3)]
        public string AppVersion { get; set; }

        [SerializationOrder(4)]
        public string LangCode { get; set; }

        [SerializationOrder(5)]
        public TlObject Query { get; set; }

        [SerializationOrder(6)]
        public TlObject Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlObject) ObjectUtils.DeserializeObject(br);
        }
    }
}