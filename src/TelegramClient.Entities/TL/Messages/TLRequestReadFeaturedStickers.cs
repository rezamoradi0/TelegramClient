using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1527873830)]
    public class TlRequestReadFeaturedStickers : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<long> Id { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}