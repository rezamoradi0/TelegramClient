namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1035688326)]
    public class TlSentCodeTypeApp : TlAbsSentCodeType
    {
        [SerializationOrder(0)]
        public int Length { get; set; }
    }
}