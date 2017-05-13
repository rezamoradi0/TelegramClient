using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-113456221)]
    public class TlRequestResolveUsername : TlMethod
    {
        [SerializationOrder(0)]
        public string Username { get; set; }

        public TlResolvedPeer Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlResolvedPeer) ObjectUtils.DeserializeObject(br);
        }
    }
}