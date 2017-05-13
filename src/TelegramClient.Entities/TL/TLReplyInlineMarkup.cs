using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1218642516)]
    public class TlReplyInlineMarkup : TlAbsReplyMarkup
    {
        [SerializationOrder(0)]
        public TlVector<TlKeyboardButtonRow> Rows { get; set; }
    }
}