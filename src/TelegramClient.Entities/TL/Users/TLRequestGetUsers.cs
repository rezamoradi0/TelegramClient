using System.IO;

namespace TelegramClient.Entities.TL.Users
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(227648840)]
    public class TlRequestGetUsers : TlMethod<TlVector<TlAbsUser>>
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputUser> Id { get; set; }
    }
}