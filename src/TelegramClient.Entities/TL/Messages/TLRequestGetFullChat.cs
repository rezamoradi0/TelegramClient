using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(998448230)]
    public class TlRequestGetFullChat : TlMethod
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }

        public TlChatFull Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlChatFull) ObjectUtils.DeserializeObject(br);
        }
    }
}