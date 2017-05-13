namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1212732749)]
    public class TlPasswordSettings : TlObject
    {
        [SerializationOrder(0)]
        public string Email { get; set; }
    }
}