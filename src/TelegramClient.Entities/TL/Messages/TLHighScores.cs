using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1707344487)]
    public class TlHighScores : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlHighScore> Scores { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}