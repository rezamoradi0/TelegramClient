using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(904138920)]
    public class TlStickerSetInstallResultArchive : TlAbsStickerSetInstallResult
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsStickerSetCovered> Sets { get; set; }
    }
}