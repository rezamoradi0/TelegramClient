using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1986437075)]
    public class TlRequestClearRecentStickers : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public int Flags { get; set; }

        public bool Attached
        {
            get => (Flags & 1) != 0;
            set => Flags = value ? 0 | 1 : 0 & ~1;
        }
    }
}