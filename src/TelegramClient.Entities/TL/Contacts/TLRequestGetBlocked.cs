using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-176409329)]
    public class TlRequestGetBlocked : TlMethod
    {
        [SerializationOrder(0)]
        public int Offset { get; set; }

        [SerializationOrder(1)]
        public int Limit { get; set; }

        public TlAbsBlocked Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsBlocked) ObjectUtils.DeserializeObject(br);
        }
    }
}