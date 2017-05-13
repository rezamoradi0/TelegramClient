using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(583445000)]
    public class TlRequestGetContacts : TlMethod
    {
        [SerializationOrder(0)]
        public string Hash { get; set; }

        public TlAbsContacts Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsContacts) ObjectUtils.DeserializeObject(br);
        }
    }
}