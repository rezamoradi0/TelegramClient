using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-256159406)]
    public class TlRequestUpdateProfilePhoto : TlMethod<TlAbsUserProfilePhoto>
    {
        [SerializationOrder(0)]
        public TlAbsInputPhoto Id { get; set; }
    }
}