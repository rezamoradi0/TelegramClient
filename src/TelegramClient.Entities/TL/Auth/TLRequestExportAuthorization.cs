using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-440401971)]
    public class TlRequestExportAuthorization : TlMethod
    {
        [SerializationOrder(0)]
        public int DcId { get; set; }

        public TlExportedAuthorization Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlExportedAuthorization) ObjectUtils.DeserializeObject(br);
        }
    }
}