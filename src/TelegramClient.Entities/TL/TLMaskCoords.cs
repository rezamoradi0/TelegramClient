using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1361650766)]
    public class TlMaskCoords : TlObject
    {
        [SerializationOrder(0)]
        public int N { get; set; }

        [SerializationOrder(1)]
        public double X { get; set; }

        [SerializationOrder(2)]
        public double Y { get; set; }

        [SerializationOrder(3)]
        public double Zoom { get; set; }
    }
}