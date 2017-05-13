using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1707432768)]
    public class TlRequestUnregisterDevice : TlMethod
    {
        [SerializationOrder(0)]
        public int TokenType { get; set; }

        [SerializationOrder(0)]
        public string Token { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}