using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1504393374)]
    public class TlRequestDeleteContacts : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputUser> Id { get; set; }

        public bool Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}