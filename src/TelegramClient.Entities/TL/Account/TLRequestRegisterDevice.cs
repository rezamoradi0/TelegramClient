using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1669245048)]
    public class TlRequestRegisterDevice : TlMethod
    {
        [SerializationOrder(0)]
        public int TokenType { get; set; }

        [SerializationOrder(1)]
        public string Token { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}