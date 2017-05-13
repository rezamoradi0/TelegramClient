using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1640190800)]
    public class TlRequestSearchGlobal : TlMethod
    {
        [SerializationOrder(0)]
        public string Q { get; set; }

        [SerializationOrder(1)]
        public int OffsetDate { get; set; }

        [SerializationOrder(2)]
        public TlAbsInputPeer OffsetPeer { get; set; }

        [SerializationOrder(3)]
        public int OffsetId { get; set; }

        [SerializationOrder(4)]
        public int Limit { get; set; }

        public TlAbsMessages Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsMessages) ObjectUtils.DeserializeObject(br);
        }
    }
}