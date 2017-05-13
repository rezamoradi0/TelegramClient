using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(537022650)]
    public class TlUserEmpty : TlAbsUser
    {
        [SerializationOrder(0)]
        public int Id { get; set; }
    }
}