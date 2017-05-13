using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2016444625)]
    public class TlRequestDeletePhotos : TlMethod<TlVector<long>>
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputPhoto> Id { get; set; }
    }
}