namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1073693790)]
    public class TlSentCodeTypeSms : TlAbsSentCodeType
    {
        [SerializationOrder(0)]
        public int Length { get; set; }
    }
}