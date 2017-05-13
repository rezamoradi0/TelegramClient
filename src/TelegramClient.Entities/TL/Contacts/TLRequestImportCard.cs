using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1340184318)]
    public class TlRequestImportCard : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<int> ExportCard { get; set; }

        public TlAbsUser Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUser) ObjectUtils.DeserializeObject(br);
        }
    }
}