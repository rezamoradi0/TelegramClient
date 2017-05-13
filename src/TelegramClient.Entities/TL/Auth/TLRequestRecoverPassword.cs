using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1319464594)]
    public class TlRequestRecoverPassword : TlMethod
    {
        [SerializationOrder(0)]
        public string Code { get; set; }

        public TlAuthorization Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAuthorization) ObjectUtils.DeserializeObject(br);
        }
    }
}