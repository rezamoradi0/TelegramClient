using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2065352905)]
    public class TlRequestExportCard : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<int> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<int>(br);
        }
    }
}