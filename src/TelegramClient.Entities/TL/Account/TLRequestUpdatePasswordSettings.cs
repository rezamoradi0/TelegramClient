using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-92517498)]
    public class TlRequestUpdatePasswordSettings : TlMethod
    {
        [SerializationOrder(0)]
        public byte[] CurrentPasswordHash { get; set; }

        [SerializationOrder(1)]
        public TlPasswordInputSettings NewSettings { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}