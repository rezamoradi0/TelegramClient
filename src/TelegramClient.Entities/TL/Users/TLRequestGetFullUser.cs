using System.IO;

namespace TelegramClient.Entities.TL.Users
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-902781519)]
    public class TlRequestGetFullUser : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputUser Id { get; set; }

        public TlUserFull Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlUserFull) ObjectUtils.DeserializeObject(br);
        }
    }
}