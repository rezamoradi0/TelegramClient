using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1834538890)]
    public class TlMessageActionGameScore : TlAbsMessageAction
    {
        [SerializationOrder(0)]
        public long GameId { get; set; }

        [SerializationOrder(1)]
        public int Score { get; set; }
    }
}