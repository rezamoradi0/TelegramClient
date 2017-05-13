using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1131605573)]
    public class TlRequestGetPasswordSettings : TlMethod
    {
        [SerializationOrder(0)]
        public byte[] CurrentPasswordHash { get; set; }

        public TlPasswordSettings Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlPasswordSettings) ObjectUtils.DeserializeObject(br);
        }
    }
}