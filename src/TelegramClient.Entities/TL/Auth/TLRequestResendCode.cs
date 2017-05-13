using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1056025023)]
    public class TlRequestResendCode : TlMethod
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }

        [SerializationOrder(1)]
        public string PhoneCodeHash { get; set; }

        public TlSentCode Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlSentCode) ObjectUtils.DeserializeObject(br);
        }
    }
}