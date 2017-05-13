using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1493171408)]
    public class TlHighScore : TlObject
    {
        [SerializationOrder(0)]
        public int Pos { get; set; }

        [SerializationOrder(1)]
        public int UserId { get; set; }

        [SerializationOrder(2)]
        public int Score { get; set; }
    }
}