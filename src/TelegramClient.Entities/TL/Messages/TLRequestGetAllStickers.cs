using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(479598769)]
    public class TlRequestGetAllStickers : TlMethod
    {
        [SerializationOrder(0)]
        public int Hash { get; set; }

        public TlAbsAllStickers Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsAllStickers) ObjectUtils.DeserializeObject(br);
        }
    }
}