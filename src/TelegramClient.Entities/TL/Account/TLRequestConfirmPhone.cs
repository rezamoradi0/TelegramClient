using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1596029123)]
    public class TlRequestConfirmPhone : TlMethod
    {
        [SerializationOrder(0)]
        public string PhoneCodeHash { get; set; }

        [SerializationOrder(1)]
        public string PhoneCode { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}