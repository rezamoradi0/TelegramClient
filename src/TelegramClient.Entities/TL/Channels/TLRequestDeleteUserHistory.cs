using System.IO;
using TelegramClient.Entities.TL.Messages;

namespace TelegramClient.Entities.TL.Channels
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-787622117)]
    public class TlRequestDeleteUserHistory : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputChannel Channel { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        public TlAffectedHistory Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAffectedHistory) ObjectUtils.DeserializeObject(br);
        }
    }
}