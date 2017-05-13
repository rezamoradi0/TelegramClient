using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2016444625)]
    public class TlRequestDeletePhotos : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputPhoto> Id { get; set; }

        public TlVector<long> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<long>(br);
        }
    }
}