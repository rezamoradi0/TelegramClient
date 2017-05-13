using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-623130288)]
    public class TlRequestGetPrivacy : TlMethod
    {
        [SerializationOrder(0)]
        public TlAbsInputPrivacyKey Key { get; set; }

        public TlPrivacyRules Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlPrivacyRules) ObjectUtils.DeserializeObject(br);
        }
    }
}