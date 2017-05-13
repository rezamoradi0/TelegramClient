using System.IO;

namespace TelegramClient.Entities.TL.Users
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(227648840)]
    public class TlRequestGetUsers : TlMethod
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsInputUser> Id { get; set; }

        public TlVector<TlAbsUser> Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<TlAbsUser>(br);
        }
    }
}