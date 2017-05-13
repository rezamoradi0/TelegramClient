using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(651135312)]
    public class TlRequestGetDhConfig : TlMethod
    {
        [SerializationOrder(0)]
        public int Version { get; set; }

        [SerializationOrder(1)]
        public int RandomLength { get; set; }

        public TlAbsDhConfig Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsDhConfig) ObjectUtils.DeserializeObject(br);
        }
    }
}