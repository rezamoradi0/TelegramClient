using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-634342611)]
    public class TlRequestImportContacts : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlInputPhoneContact> Contacts { get; set; }

        [SerializationOrder(1)]
        public bool Replace { get; set; }

        public TlImportedContacts Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlImportedContacts) ObjectUtils.DeserializeObject(br);
        }
    }
}