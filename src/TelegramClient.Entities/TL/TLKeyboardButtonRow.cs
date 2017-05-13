using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(2002815875)]
    public class TlKeyboardButtonRow : TlObject
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsKeyboardButton> Buttons { get; set; }
    }
}