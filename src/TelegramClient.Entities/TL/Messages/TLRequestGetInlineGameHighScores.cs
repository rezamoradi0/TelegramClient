using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(258170395)]
    public class TlRequestGetInlineGameHighScores : TlMethod
    {
        [SerializationOrder(0)]
        public TlInputBotInlineMessageId Id { get; set; }

        [SerializationOrder(1)]
        public TlAbsInputUser UserId { get; set; }

        public TlHighScores Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlHighScores) ObjectUtils.DeserializeObject(br);
        }
    }
}