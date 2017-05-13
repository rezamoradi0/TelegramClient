using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1328726168)]
    public class TlRequestUploadProfilePhoto : TlMethod<TlPhoto>
    {
        [SerializationOrder(0)]
        public TlAbsInputFile File { get; set; }
    }
}