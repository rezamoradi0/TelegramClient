using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1902823612)]
    public class TlRequestDeleteContact : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputUser Id { get; set; }

        public TlLink Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlLink) ObjectUtils.DeserializeObject(br);
        }
    }
}