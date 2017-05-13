using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-750828557)]
    public class TlInputMediaGame : TlAbsInputMedia
    {
        [SerializationOrder(0)]
        public TlAbsInputGame Id { get; set; }
    }
}