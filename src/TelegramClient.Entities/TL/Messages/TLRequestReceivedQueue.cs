using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1436924774)]
    public class TlRequestReceivedQueue : TlMethod
    {
        [SerializationOrder(0)]
        public int MaxQts { get; set; }

        public TlVector<long> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<long>(br);
        }
    }
}