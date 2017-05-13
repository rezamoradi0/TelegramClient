using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1662091044)]
    public class TlWallPaperSolid : TlAbsWallPaper
    {
        [SerializationOrder(0)]
        public int Id { get; set; }

        [SerializationOrder(1)]
        public string Title { get; set; }

        [SerializationOrder(2)]
        public int BgColor { get; set; }

        [SerializationOrder(3)]
        public int Color { get; set; }
    }
}