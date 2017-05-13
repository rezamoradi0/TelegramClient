using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1040964988)]
    public class TlRequestUpdateUsername : TlMethod
    {
        [SerializationOrder(0)]
        public string Username { get; set; }

        public TlAbsUser Response { get; set; }


        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUser) ObjectUtils.DeserializeObject(br);
        }
    }
}