using System.IO;

namespace TelegramClient.Entities.TL.Auth
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-440401971)]
    public class TlRequestExportAuthorization : TlMethod<TlExportedAuthorization>
    {
        [SerializationOrder(0)]
        public int DcId { get; set; }
    }
}