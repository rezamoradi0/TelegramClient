using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1444503762)]
    public class TlRequestEditChatAdmin : TlMethod
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        [SerializationOrder(2)]
        public bool IsAdmin { get; set; }

        public bool Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}