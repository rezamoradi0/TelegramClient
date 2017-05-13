 
using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-304536635)]
    public class TlRequestDiscardEncryption : TlMethod
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}