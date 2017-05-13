using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-256159406)]
    public class TlRequestUpdateProfilePhoto : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPhoto Id { get; set; }

        public TlAbsUserProfilePhoto Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsUserProfilePhoto) ObjectUtils.DeserializeObject(br);
        }
    }
}