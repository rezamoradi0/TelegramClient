using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(168039573)]
    public class TlRequestGetDifference : TlMethod
    {
        [SerializationOrder(0)]
        public int Pts { get; set; }

        [SerializationOrder(1)]
        public int Date { get; set; }

        [SerializationOrder(2)]
        public int Qts { get; set; }

        public TlAbsDifference Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsDifference) ObjectUtils.DeserializeObject(br);
        }
    }
}