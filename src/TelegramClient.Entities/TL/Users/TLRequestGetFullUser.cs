using System.IO;

namespace TelegramClient.Entities.TL.Users
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-902781519)]
    public class TlRequestGetFullUser : TlMethod<TlUserFull>
    {
        [SerializationOrder(0)]
        public TlAbsInputUser Id { get; set; }
    }
}