using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(453408308)]
    public class TlRequestSignUp : TlMethod
    {
        [SerializationOrder(0)]
        public string PhoneNumber { get; set; }

        [SerializationOrder(1)]
        public string PhoneCodeHash { get; set; }

        [SerializationOrder(2)]
        public string PhoneCode { get; set; }

        [SerializationOrder(3)]
        public string FirstName { get; set; }

        [SerializationOrder(4)]
        public string LastName { get; set; }

        public TlAuthorization Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAuthorization) ObjectUtils.DeserializeObject(br);
        }
    }
}