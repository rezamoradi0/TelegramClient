using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(954152242)]
    public class TlRequestUpdateDeviceLocked : TlMethod
    {
        [SerializationOrder(0)]
        public int Period { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}