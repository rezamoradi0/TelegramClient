using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(94983360)]
    public class TlRequestReceivedMessages : TlMethod
    {
        [SerializationOrder(0)]
        public int MaxId { get; set; }

        public TlVector<TlReceivedNotifyMessage> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<TlReceivedNotifyMessage>(br);
        }
    }
}