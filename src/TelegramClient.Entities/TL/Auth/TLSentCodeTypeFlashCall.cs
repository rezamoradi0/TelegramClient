namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1425815847)]
    public class TlSentCodeTypeFlashCall : TlAbsSentCodeType
    {
        [SerializationOrder(0)]
        public string Pattern { get; set; }
    }
}