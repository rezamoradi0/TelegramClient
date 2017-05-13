using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-400399203)]
    public class TlRequestGetGameHighScores : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPeer Peer { get; set; }

        [SerializationOrder(1)]
        public int Id { get; set; }

        [SerializationOrder(2)]
        public TlAbsInputUser UserId { get; set; }

        public TlHighScores Response { get; set; }

        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlHighScores) ObjectUtils.DeserializeObject(br);
        }
    }
}