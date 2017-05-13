using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-484392616)]
    public class TlRequestGetAuthorizations : TlMethod
    {
        public TlAuthorizations Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAuthorizations) ObjectUtils.DeserializeObject(br);
        }
    }
}