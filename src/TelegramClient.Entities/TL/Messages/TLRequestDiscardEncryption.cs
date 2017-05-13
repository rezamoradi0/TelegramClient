 
namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-304536635)]
    public class TlRequestDiscardEncryption : TlMethod<bool>
    {
        [SerializationOrder(0)]
        public int ChatId { get; set; }
    }
}