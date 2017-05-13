using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(174260510)]
    public class TlRequestCheckPassword : TlMethod
    {
        [SerializationOrder(0)]
        public byte[] PasswordHash { get; set; }

        public TlAuthorization Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAuthorization) ObjectUtils.DeserializeObject(br);
        }
    }
}