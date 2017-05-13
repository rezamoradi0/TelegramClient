using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(1051570619)]
    public class TlRequestCheckChatInvite : TlMethod
    {
        [SerializationOrder(0)]
        public string Hash { get; set; }

        public TlAbsChatInvite Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsChatInvite) ObjectUtils.DeserializeObject(br);
        }
    }
}