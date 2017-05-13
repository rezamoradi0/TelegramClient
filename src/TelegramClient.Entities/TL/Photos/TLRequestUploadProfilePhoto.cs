using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1328726168)]
    public class TlRequestUploadProfilePhoto : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputFile File { get; set; }
        
        public TlPhoto Response { get; set; }
        
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlPhoto) ObjectUtils.DeserializeObject(br);
        }
    }
}