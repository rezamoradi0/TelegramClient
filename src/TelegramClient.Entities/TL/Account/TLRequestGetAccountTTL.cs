using System.IO;

namespace TelegramClient.Entities.TL.Account
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(150761757)]
    public class TlRequestGetAccountTtl : TlMethod
    {
        public TlAccountDaysTtl Response { get; set; }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAccountDaysTtl) ObjectUtils.DeserializeObject(br);
        }
    }
}